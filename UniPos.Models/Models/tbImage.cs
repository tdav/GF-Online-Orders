using System.Collections.Generic;

namespace UniPos.Models
{

    /// <summary>
    /// таблица Фото лекарств
    /// </summary>
    public class tbImage : BaseModel
    {
        public int Id { get; set; }

        public int MainId { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }
}
