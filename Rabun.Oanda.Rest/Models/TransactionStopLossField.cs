﻿namespace Rabun.Oanda.Rest.Models
{
    public class TransactionStopLossField : TransactionSimple
    {
        public int TradeId { get; set; }
        public float Pl { get; set; }
        public int Interest { get; set; }
        public float AccountBalance { get; set; }
    }
}