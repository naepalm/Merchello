﻿namespace Merchello.Core
{
    public partial class Constants
    {
        public static class StrategyTypeAlias
        {
            public static string DefaultPackaging = "DefaultPackaging";
            public static string DefaultShipmentRateQuote = "DefaultShipmentRateQuote";
            public static string DefaultInvoiceTaxRateQuote = "DefaultInvoiceTaxRateQuote";
        }

        public static class TaskChainAlias
        {
            public static string SalesPreparationInvoiceCreate = "SalesPreparationInvoiceCreate";
            public static string OrderPreparationOrderCreate = "OrderPreparationOrderCreate";
            public static string OrderPreparationShipmentCreate = "OrderPreparationShipmentCreate";
        }
    }
}