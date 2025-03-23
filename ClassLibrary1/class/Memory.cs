using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Memory;

namespace Calculator.Memory
{
    // Санах ойн зүйл (MemoryItem) ангилал
    // Энэ ангилал нь санах ойн нэгжийн утга ба цаг хугацааг хадгалж, нэмэх болон хасах үйлдлүүдийг хийхэд ашиглагдана
    public class MemoryItem
    {
        // Утга (Value) нь санах ойн тухайн зүйлсийн утга
        public double Value { get;  set; }
        public int ID { get; set; }

        // Тохиромжтой цаг хугацаа (Timestamp) нь санах ойн зүйлсийг хадгалахын цагийг зааж байна
        private static int _idCounter = 1;

        // Конструктор: Санах ойн зүйлсийг үүсгэхдээ утга авах бөгөөд
        // цаг хугацааг автоматаар олгоно
        public MemoryItem(double value)
        {
            Value = value;
            ID = _idCounter++;
        }

        // MPlus: Санах ойн эцсийн утга болон шинэ утгыг нэмэх үйлдэл
        // `number` нь нэмэгдэх утга бөгөөд `lastMemory` нь өмнөх санах ойн зүйлс
        
    }
}


