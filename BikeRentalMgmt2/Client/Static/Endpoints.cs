using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Client.Static
{
    public static class Endpoints
    {
        public static readonly string Prefix = "api";

        public static readonly string BikesEndpoint = $"{Prefix}/bikes";
        public static readonly string BranchesEndpoint = $"{Prefix}/branches";
        public static readonly string StaffEndpoint = $"{Prefix}/staff";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string RentOrdersEndpoint = $"{Prefix}/rentorders";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
    }
}
