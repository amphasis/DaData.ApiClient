﻿using DadataApiClient.Models.Suggests.Data;

namespace DadataApiClient.Models.Standartization.Data
{
    public class DadataCarQueryResult 
    {
        public string Source { get; set; }

        public string Result { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Qc { get; set; }
    }
}