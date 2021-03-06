﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace AllReady.Areas.Admin.Models.ItineraryModels
{
    /// <summary>
    /// Defines data used by the admin itinerary details page
    /// </summary>
    public class ItineraryDetailsModel
    {
        /// <summary>
        /// The ID of the itinerary being displayed
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the itinerary being displayed
        /// </summary>
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int OrganizationId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }

        public int SelectedTeamMember { get; set; }
        public IEnumerable<SelectListItem> PotentialTeamMembers { get; set; } = new List<SelectListItem>();
        public bool HasPotentialTeamMembers { get; set; }

        public List<TeamListModel> TeamMembers { get; set; } = new List<TeamListModel>();
        public List<RequestListModel> Requests { get; set; } = new List<RequestListModel>();

        public string DisplayDate => Date.ToLongDateString();
    }
}
