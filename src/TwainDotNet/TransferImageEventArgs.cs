﻿using System;
using System.Drawing;

namespace TwainDotNet
{
    public class TransferImageEventArgs : EventArgs
    {
        public Bitmap Image { get; private set; }
        public Bitmap[] Images { get; private set; }
        public bool ContinueScanning { get; set; }

        public TransferImageEventArgs(Bitmap image, bool continueScanning)
        {
            this.Image = image;
            this.ContinueScanning = continueScanning;
        }
        public TransferImageEventArgs(Bitmap[] images, bool continueScanning) {
            this.Images = images;
            this.ContinueScanning = continueScanning;
        }
    }
}
