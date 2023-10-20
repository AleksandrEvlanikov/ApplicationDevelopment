﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationDevelopment.Dz2.implicitСast;


namespace ApplicationDevelopment.Dz2
{
    public class implicitСast
    {
        public class Bits : IBits
        {
            public Bits(byte b)
            {
                this.Value = b;
                MaxBitsCount = sizeof(byte) * 8;
            }

            public Bits(short b)
            {
                this.Value = b;
                MaxBitsCount = sizeof(short) * 8;
            }

            public Bits(int b)
            {
                this.Value = b;
                MaxBitsCount = sizeof(int) * 8;
            }

            public Bits(long b)
            {
                this.Value = b;
                MaxBitsCount = sizeof(long) * 8;
            }

            public static implicit operator byte(Bits b) => (byte)b.Value;
            public static explicit operator Bits(byte b) => new Bits(b);

            public long Value { get; set; } = 0;
            private int MaxBitsCount { get; set; }

            public override string? ToString()
            {
                return base.ToString();
            }

            public bool GetBit(int index)
            {
                if (index > MaxBitsCount || index < 0)
                {
                    Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                    return false;
                }

                return ((Value >> index) & 1) == 1;
            }

            public void SetBit(bool bit, int index)
            {
                if (index > MaxBitsCount || index < 0)
                {
                    Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                    return;
                }
                if (bit == true)
                    Value = (byte)(Value | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask = (byte)(0xff ^ mask);
                    Value &= (byte)(Value & mask);
                }
            }
        }



    }
}

