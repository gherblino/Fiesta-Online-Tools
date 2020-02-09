using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropTableEditor.SHN
{
    public class ShnColumn
        : DataColumn
    {
        public ShnColumnType Type { get; set; }
        public int Length { get; set; }

        public ShnColumn(string name, int type, int length = 0)
            : base(name)
        {
            Type = new ShnColumnType(type);
            Length = length;
        }

        public class ShnColumnType
        {
            public int TypeId { get; set; }
            public Type DataType { get; set; }

            private ShnColumnType(int typeId, Type dataType)
            {
                TypeId = typeId;
                DataType = dataType;
            }

            public ShnColumnType(int typeId) : this(typeId, getDataType(typeId)) { }

            private static Type getDataType(int typeId)
            {
                switch (typeId)
                {
                    case 1:
                    case 12:
                    case 16:
                        return typeof(byte);

                    case 2:
                        return typeof(ushort);

                    case 3:
                    case 11:
                    case 18:
                    case 27:
                        return typeof(uint);

                    case 5:
                        return typeof(float);

                    case 9:
                    case 24:
                        return typeof(string);

                    case 13:
                    case 21:
                        return typeof(short);

                    case 20:
                        return typeof(sbyte);

                    case 22:
                        return typeof(int);

                    case 26:
                        return typeof(string);

                    default:
                        return typeof(object);
                }
            }
        }
    }
}
