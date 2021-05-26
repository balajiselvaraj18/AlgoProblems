//using System;
//using System.Collections.Generic;
//public class Program
//{
//    public static OrgChart GetLowestCommonManager(OrgChart topManager, OrgChart reportOne,
//      OrgChart reportTwo)
//    {
//        // Write your code here.
//        return getOrgInfo(topManager, reportOne, reportTwo).LowestCommonManager; // Replace this line.
//    }

//    public static OrgInfo getOrgInfo(OrgChart manager, OrgChart reportOne,      OrgChart reportTwo)
//    {
//        int visitedReports = 0;
//        foreach (OrgChart directReport in manager.directReports)
//        {
//            OrgInfo info = getOrgInfo(directReport, reportOne, reportTwo);
//            if (info.LowestCommonManager != null)
//            {
//                return info;
//            }
//            visitedReports = visitedReports + info.visitedReports;
//        }

//        if (manager == reportOne || manager == reportTwo)
//        {
//            visitedReports++;
//        }
//        OrgChart lowestCommonManager = visitedReports == 2 ? manager : null;
//        OrgInfo newInfo = new OrgInfo(lowestCommonManager, visitedReports);
//        return newInfo;

//    }

//    public class OrgChart
//    {
//        public char name;
//        public List<OrgChart> directReports;

//        public OrgChart(char name)
//        {
//            this.name = name;
//            this.directReports = new List<OrgChart>();
//        }

//        // This method is for testing only.
//        public void addDirectReports(OrgChart[] directReports)
//        {
//            foreach (OrgChart directReport in directReports)
//            {
//                this.directReports.Add(directReport);
//            }
//        }
//    }

//    public class OrgInfo
//    {
//        public OrgChart LowestCommonManager;
//        public int visitedReports;

//        public OrgInfo(OrgChart LowestCommonManager, int visitedReports)
//        {
//            this.LowestCommonManager = LowestCommonManager;
//            this.visitedReports = visitedReports;
//        }

//    }
//}
