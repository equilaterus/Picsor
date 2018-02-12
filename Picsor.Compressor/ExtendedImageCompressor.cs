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
        public static Bitmap ResizePercentage(this ImageCompressor imageCompressor, float percentage)
        {
            percentage = Math.Min(1, percentage);
            percentage = Math.Max(0, percentage);

            return imageCompressor.Resize(
                (int)(imageCompressor.ImageWidth * percentage),
                (int)(imageCompressor.ImageHeight * percentage));
        }

        public static Bitmap ResizeMaxDimensions(this ImageCompressor imageCompressor, int MaxWidth, int MaxHeight)
        {
            var percentageWidth = ((float)MaxWidth / (float)imageCompressor.ImageWidth);
            var percentageHeight = ((float)MaxHeight / (float)imageCompressor.ImageHeight);

            float percentage = Math.Min(percentageWidth, percentageHeight);

            return ResizePercentage(imageCompressor, percentage);
        }
    }
}
