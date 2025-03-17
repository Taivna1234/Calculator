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
        public double Value { get; private set; }

        // Тохиромжтой цаг хугацаа (Timestamp) нь санах ойн зүйлсийг хадгалахын цагийг зааж байна
        public DateTime Timestamp { get; }

        // Конструктор: Санах ойн зүйлсийг үүсгэхдээ утга авах бөгөөд
        // цаг хугацааг автоматаар олгоно
        public MemoryItem(double value)
        {
            Value = value;
            Timestamp = DateTime.Now; // Одоо цагийг авах
        }

        // MPlus: Санах ойн эцсийн утга болон шинэ утгыг нэмэх үйлдэл
        // `number` нь нэмэгдэх утга бөгөөд `lastMemory` нь өмнөх санах ойн зүйлс
        public static MemoryItem MPlus(double number, MemoryItem lastMemory)
        {
            double lastValue = lastMemory?.Value ?? 0; // Хэрэв өмнөх санах ойн зүйл байхгүй бол 0 утгыг авна
            return new MemoryItem(lastValue + number); // Шинэ санах ойн зүйл үүсгэж, утгыг нэмнэ
        }

        // MMinus: Санах ойн эцсийн утга болон шинэ утгыг хасах үйлдэл
        // `number` нь хасагдах утга бөгөөд `lastMemory` нь өмнөх санах ойн зүйлс
        public static MemoryItem MMinus(double number, MemoryItem lastMemory)
        {
            double lastValue = lastMemory?.Value ?? 0; // Хэрэв өмнөх санах ойн зүйл байхгүй бол 0 утгыг авна
            return new MemoryItem(lastValue - number); // Шинэ санах ойн зүйл үүсгэж, утгыг хасна
        }
    }
}


