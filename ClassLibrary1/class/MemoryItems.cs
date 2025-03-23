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
        public List<MemoryItem> memoryItems = new List<MemoryItem>();

        // Save: Шинэ санах ойн зүйлсийг хадгалах
        // `item` нь санах ойн шинэ зүйл бөгөөд үүнийг жагсаалтад нэмнэ
        public void Save(MemoryItem item)
        {
            memoryItems.Add(item);
        }
        public MemoryItem GetMemoryItemById(int id)
        {
            return memoryItems.FirstOrDefault(item => item.ID == id);
        }

        // GetLastMemory: Санах ойн хамгийн сүүлийн зүйлсийг авах
        // Хэрэв санах ойн зүйлс байхгүй бол шинэ MemoryItem (0 утга) буцаана
        public MemoryItem GetLastMemory()
        {
            return memoryItems.Count > 0 ? memoryItems.Last() : new MemoryItem(0);
        }

        // MPlus: Санах ойн хамгийн сүүлийн зүйлсэд тодорхой утга нэмэх
        // `number` нь нэмэгдэх утга бөгөөд сүүлийн санах ойн зүйлд нэмэгдэх болно
        public void MPlus(double number, int id)
        {
            var memoryItem = GetMemoryItemById(id);
            if (memoryItem != null)
            {
                memoryItem.Value += number;
            }
        }

        public void MMinus(double number, int id)
        {
            var memoryItem = GetMemoryItemById(id);
            if (memoryItem != null)
            {
                memoryItem.Value -= number;
            }
        }

        // Clear: Бүх санах ойн зүйлсийг цэвэрлэх
        public void Clear()
        {
            memoryItems.Clear(); // Санах ойн жагсаалтыг цэвэрлэх
        }
        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }
        public List<double> GetMemoryValues()
        {
            return memoryItems.Select(item => item.Value).ToList();
        }
    }
}

