﻿using System.Collections.Generic;

namespace FFDConverter
{
    public struct generalInfoFFD
    {
        public string fontName;
        public byte pagesCount;
        public ushort charsCount;
        public bool table1EqualZero;
        public short table2Value;
        public short table5Value;
        public short kernsCount;
        public List<string> BitmapName;

        public void CreateListBitmapName()
        {
            this.BitmapName = new();
        }
    }

    public struct charDescFFD
    {
        public ushort id;
        public byte page;
        public float UVLeft;
        public float UVTop;
        public float UVRight;
        public float UVBottom;
        public short xoffset;
        public short yoffset;
        public ushort widthScale;
        public ushort heightScale;

    }

    public struct xadvanceDescFFD
    {
        public byte unk;
        public byte xadvanceScale;
    }

    public struct kernelDescFFD
    {
        public short first;
        public short second;
        public short amountScale;
    }

    public struct UnknownStuff_FC5
    {
        public byte[] unkHeader1;
        public byte[] unkHeader2;
        public byte[] unkHeader3;
        public byte[] unk6bytes;
        public byte[] unkFooter;
    }
}
