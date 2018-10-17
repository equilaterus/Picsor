using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Picsor.Compressor
{
    public static class ExtendedImageCompressor
    {
        public static Bitmap GetResizedUsingPercentage(this ImageCompressor imageCompressor, float percentage)
        {
            percentage = Math.Min(1, percentage);
            percentage = Math.Max(0, percentage);

            return imageCompressor.GetResized(
                (int)(imageCompressor.ImageWidth * percentage),
                (int)(imageCompressor.ImageHeight * percentage));
        }

        public static Bitmap GetResizeUsingMaxDimensions(this ImageCompressor imageCompressor, int MaxWidth, int MaxHeight)
        {
            var percentageWidth = (float)imageCompressor.ImageWidth / MaxWidth;
            var percentageHeight = (float)imageCompressor.ImageHeight / MaxHeight;

            if (percentageWidth < 1 && percentageHeight < 1)
                return null;

            if (percentageWidth > percentageHeight)
                return imageCompressor.GetResized(MaxWidth, MaxWidth * imageCompressor.ImageHeight / imageCompressor.ImageWidth);
            else if (percentageWidth < percentageHeight)
                return imageCompressor.GetResized(MaxHeight * imageCompressor.ImageWidth / imageCompressor.ImageHeight, MaxHeight);
            else
                return imageCompressor.GetResized(MaxWidth, MaxHeight);
        }
    }
}
