﻿using SWD.TicketBooking.Repo.Entities;
using SWD.TicketBooking.Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD.TicketBooking.Repo.Repositories
{

    public class StationCompany_RouteRepository : GenericRepository<StationCompany_Route, Guid>, IStationCompany_RouteRepository
    {
        public StationCompany_RouteRepository(TicketBookingDbContext context) : base(context) { }
    }
}
