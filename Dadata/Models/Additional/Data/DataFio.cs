﻿using DaData.Models.Enums;

namespace DaData.Models.Additional.Data
{
    public class DataFio
    {
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public Gender Gender { get; set; }

        public string Source { get; set; }

        public int? Qc { get; set; }
    }
}