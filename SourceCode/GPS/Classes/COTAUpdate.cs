using System;


using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using System.ComponentModel.Design;

namespace OpenGrade.Classes
{
    public class COTAUpdate
    {
        private readonly string _githubRepoUrl;
        private readonly string _firmwareFileName;
        private readonly string _filesystemFileName;
        private readonly string _versionFileName;

        public COTAUpdate(string githubRepoUrl, string firmwareFileName, string filesystemFileName, string versionFileName)
        {
            _githubRepoUrl = githubRepoUrl;
            _firmwareFileName = firmwareFileName;
            _filesystemFileName = filesystemFileName;
            _versionFileName = versionFileName;
        }

        public async Task UpdateESP32FromWeb(string esp32IpAddress)
        {
            try
            {
                // Check ESP32 firmware version
                var currentVersion = await GetEsp32FirmwareVersion(esp32IpAddress);
                var latestVersion = await GetLatestFirmwareVersion();

                if (string.IsNullOrEmpty(latestVersion))
                {
                    MessageBox.Show("Failed to retrieve the latest firmware version.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (currentVersion == latestVersion)
                {
                    MessageBox.Show("ESP32 firmware is already up to date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Download firmware
                var firmwareUrl = $"{_githubRepoUrl}/{_firmwareFileName}";
                var firmwareData = await DownloadFileAsync(firmwareUrl);

                // Download filesystem
                var filesystemUrl = $"{_githubRepoUrl}/{_filesystemFileName}";
                var filesystemData = await DownloadFileAsync(filesystemUrl);

                // Upload to ESP32
                await UpdateESP32WithData(esp32IpAddress, firmwareData, filesystemData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateESP32FromLocalFile(string esp32IpAddress, string firmwareFilePath, string filesystemFilePath)
        {
            try
            {
                if (!File.Exists(firmwareFilePath))
                    throw new FileNotFoundException($"Firmware file not found: {firmwareFilePath}");

                if (!File.Exists(filesystemFilePath))
                    throw new FileNotFoundException($"Filesystem file not found: {filesystemFilePath}");

                // Read the local files
                var firmwareData = File.ReadAllBytes(firmwareFilePath);
                var filesystemData = File.ReadAllBytes(filesystemFilePath);

                // Upload to ESP32
                await UpdateESP32WithData(esp32IpAddress, firmwareData, filesystemData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetEsp32FirmwareVersion(string esp32IpAddress)
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync($"http://{esp32IpAddress}/version");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to retrieve ESP32 version. Status code: {response.StatusCode}");
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching ESP32 firmware version: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private async Task<string> GetLatestFirmwareVersion()
        {
            try
            {
                var versionUrl = $"{_githubRepoUrl}/{_versionFileName}";
                var client = new HttpClient();
                var response = await client.GetAsync(versionUrl);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to retrieve the latest firmware version. Status code: {response.StatusCode}");
                }

                var versionData = await response.Content.ReadAsStringAsync();
                return versionData.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching latest firmware version: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private async Task UpdateESP32WithData(string esp32IpAddress, byte[] firmwareData, byte[] filesystemData)
        {
            // Upload firmware
            var firmwareUpdateSuccess = await UploadToESP32(esp32IpAddress, 3232, firmwareData);
            if (!firmwareUpdateSuccess)
            {
                MessageBox.Show("Firmware update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Upload filesystem
            var filesystemUpdateSuccess = await UploadToESP32(esp32IpAddress, 3232, filesystemData, true);
            if (!filesystemUpdateSuccess)
            {
                MessageBox.Show("Filesystem update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("ESP32 updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<byte[]> DownloadFileAsync(string fileUrl)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(fileUrl);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to download file from {fileUrl}. Status code: {response.StatusCode}");
            }

            return await response.Content.ReadAsByteArrayAsync();
        }

        //private async Task<bool> UploadToESP32(string ipAddress, string type, byte[] data)
        public async Task<bool> UploadToESP32(string esp32Ip, int otaPort, byte[] Data, bool isFileSystem = false)
        {
            try
            {

                //using (TcpClient client = new TcpClient())
                //{
                //    await client.ConnectAsync(esp32Ip, otaPort);
                using (UdpClient udpClient = new UdpClient())
                {
                    // Connect to ESP32
                    udpClient.Connect(esp32Ip, otaPort);
                    await SendHandshakeAsync(udpClient, Data);

                }

                Console.WriteLine($"{(isFileSystem ? "Filesystem" : "Firmware")} update completed successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during OTA update: {ex.Message}");
                return false;
            }
        }

        private string CalculateMD5(byte[] data)
        {
            
                MD5 md5 = MD5.Create();
                byte[] hashBytes = md5.ComputeHash(data);

                // Convert the hash bytes to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Format as hexadecimal
                }

                return sb.ToString();
            
        }
        private async Task SendHandshakeAsync(UdpClient udpClient, byte [] data)
        {
            // Handshake format might differ; this is a basic implementation
            //string handshake = "0cfcd208495d565ef66e7dff9f98764da \n";



            SendCommand(100, 3232, data, udpClient);

            

            //string checksum = CalculateMD5(data);
            //byte[] handshakeBytes = Encoding.UTF8.GetBytes(checksum);


            //await udpClient.SendAsync(handshakeBytes, handshakeBytes.Length);

            //SendCommand(cmd, port, firmwarePath, password);

            // Receive handshake response
            var response = await udpClient.ReceiveAsync();
            string responseMessage = Encoding.UTF8.GetString(response.Buffer);

            //await networkStream.WriteAsync(handshakeBytes, 0, handshakeBytes.Length);
            //await networkStream.FlushAsync();

            //byte[] responseBuffer = new byte[1024];
            //int responseLength = await networkStream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
            //string response = Encoding.UTF8.GetString(responseBuffer, 0, responseLength);

            if (!responseMessage.Contains("OK"))
                throw new Exception("Handshake failed. ESP32 response: " + response);
        }

        private void SendCommand(int cmd, int otaPort, byte [] data, UdpClient udpClient)
        {
            // Calculate MD5 checksum of the firmware
            string md5Checksum = CalculateMD5(data);

            // Construct the command packet
            string command = $"{cmd}\n{otaPort}\n{data.Length}\n{md5Checksum}\n";

            command = $"{cmd}\n{md5Checksum}\n";

            command = $"{cmd} {otaPort}\n{md5Checksum}";

            //command = cmd  + otaPort + data.Length + md5Checksum + "\n";



            byte[] send = Encoding.UTF8.GetBytes(command);

            // Send the command
            udpClient.SendAsync(send, send.Length);


            //Log($"Sent command: {command}");
        }

        private async Task SendFirmwareAsync(NetworkStream networkStream, string firmwareFilePath)
        {
            byte[] buffer = new byte[4096];
            using (var fileStream = new FileStream(firmwareFilePath, FileMode.Open, FileAccess.Read))
            {
                int bytesRead;
                while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await networkStream.WriteAsync(buffer, 0, bytesRead);
                    await networkStream.FlushAsync();
                }
            }
        }

        private async Task ReceiveCompletionAckAsync(NetworkStream networkStream)
        {
            byte[] responseBuffer = new byte[1024];
            int responseLength = await networkStream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
            string response = Encoding.UTF8.GetString(responseBuffer, 0, responseLength);

            if (!response.Contains("OK"))
                throw new Exception("Firmware upload failed. ESP32 response: " + response);

            Console.WriteLine("ESP32 acknowledged firmware update. Update successful!");
        }

    }
}




