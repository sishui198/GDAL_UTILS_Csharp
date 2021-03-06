﻿namespace RasterizeCsharp.AppUtils
{
    public class RasterInfo
    {
        public int RasterWidth { get; set; }
        public int RasterHeight { get; set; }
    }

    public static class GdalUtilConstants
    {
        public const double NoDataValue = -999.0;
        public const int RasterBlockSize = 512;
    }
}
