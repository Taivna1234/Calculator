using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Memory;
using Calculator;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Memory
{
    // Санах ойн удирдлага (Memori) ангилал
    // Энэ ангилал нь санах ойн зүйлсийг хадгалж, нэмэх, хасах, цэвэрлэх үйлдлүүдийг гүйцэтгэнэ.
    public class Memori
    {
        // Санах ойн зүйлсийн жагсаалт (memoryItems)
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        // Save: Шинэ санах ойн зүйлсийг хадгалах
        // `item` нь санах ойн шинэ зүйл бөгөөд үүнийг жагсаалтад нэмнэ
        public void Save(MemoryItem item)
        {
            memoryItems.Add(item);
        }

        // GetLastMemory: Санах ойн хамгийн сүүлийн зүйлсийг авах
        // Хэрэв санах ойн зүйлс байхгүй бол шинэ MemoryItem (0 утга) буцаана
        public MemoryItem GetLastMemory()
        {
            return memoryItems.Count > 0 ? memoryItems.Last() : new MemoryItem(0);
        }

        // MPlus: Санах ойн хамгийн сүүлийн зүйлсэд тодорхой утга нэмэх
        // `number` нь нэмэгдэх утга бөгөөд сүүлийн санах ойн зүйлд нэмэгдэх болно
        public void MPlus(double number)
        {
            MemoryItem lastMemory = GetLastMemory();
            Save(MemoryItem.MPlus(number, lastMemory)); // Шинэ санах ойн зүйлс үүсгэн хадгална
        }

        // MMinus: Санах ойн хамгийн сүүлийн зүйлсээс тодорхой утга хасах
        // `number` нь хасагдах утга бөгөөд сүүлийн санах ойн зүйлсээс хасагдах болно
        public void MMinus(double number)
        {
            MemoryItem lastMemory = GetLastMemory();
            Save(MemoryItem.MMinus(number, lastMemory)); // Шинэ санах ойн зүйлс үүсгэн хадгална
        }

        // Clear: Бүх санах ойн зүйлсийг цэвэрлэх
        public void Clear()
        {
            memoryItems.Clear(); // Санах ойн жагсаалтыг цэвэрлэх
        }
    }
}

