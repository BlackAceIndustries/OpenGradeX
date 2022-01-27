public void AutoDrain()
{
    vec2 temp = new vec2();
                
    double distFromLastPlot = 0;
    int drawPts;
    int ptCnt = ct.ptList.Count;
    double minDeltaHt = 0;
    double angle = (vehicle.minSlope) * 180;
    int startPt = 0;
    int endPt = -1;
    int lowestPt = 0;
    int upCnt = 0;

    int MaxUpcount = 2; //can be set higher or lower 
    
    ct.drawList.Clear();   

    //check to find the first low point and call it the start point        
    for (int k = 1; k < ptCnt; k++)
    {                        
        if (ct.ptList[k].altitude <= ct.ptList[k-1].altitude)
        {
            lowestPt = k;
        }
        else 
        {
            upCnt++;
        }
        if (upCnt == 2)
        {
            startPt = lowestPt;                    
            break;
        }             
    }
    for (int i = startPt; i < ptCnt; i++)
    {
        // check to see if drawlist has any points 
        drawPts = ct.drawList.Count;       
        
        if (drawPts > 0)
        {
            //calculate the distance from point i to last tempPt
            for (int h = (int)ct.drawList[drawPts -1].easting; h < i; h++)  // calculate distance from last point if first point is set
            {
                distFromLastPlot += ct.ptList[h].distance;  // add distance all distances from lastPt to hPt 
            }
        }
        else
        {
            // add first point
            temp.easting = i;   // (double)ct.ptList[i].easting;                            
            temp.northing = ((double)ct.ptList[i].altitude);
            ct.drawList.Add(temp);
            drawPts = ct.drawList.Count;                                                        
        }
        
        minDeltaHt = (Math.Tan((angle * (Math.PI / 180))) * distFromLastPlot);                 
        temp.easting = i;
        temp.northing = ((double)ct.ptList[i].altitude);                    
                                
        if (ct.ptList[i].altitude) < ct.drawList[drawPts - 1].northing + minDeltaHt) 
        {
            ct.drawList.Add(temp);                           
        }
        distFromLastPlot = 0;        
    }
    endPt = drawPts -1;
}


