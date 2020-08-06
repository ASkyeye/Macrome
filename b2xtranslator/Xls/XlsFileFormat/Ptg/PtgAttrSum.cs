using System;
using System.Diagnostics;
using b2xtranslator.StructuredStorage.Reader;

namespace b2xtranslator.Spreadsheet.XlsFileFormat.Ptg
{
    public class PtgAttrSum : AbstractPtg
    {
        public const Ptg0x19Sub ID = Ptg0x19Sub.PtgAttrSum;

        public ushort Unused;


        public PtgAttrSum(IStreamReader reader, Ptg0x19Sub ptgid)
            :
            base(reader, ptgid)
        {
            Debug.Assert((Ptg0x19Sub)this.Id == ID);
            this.Length = 4;
            this.Data = "SUM";
            this.type = PtgType.Operator;
            this.popSize = 1;
            this.Unused = Convert.ToUInt16(this.Reader.ReadBytes(2)); 
        }
    }
}
