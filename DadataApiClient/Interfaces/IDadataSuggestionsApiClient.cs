﻿using System;
using System.Threading.Tasks;
using DadataApiClient.Models.Suggestions.ShortResponses;
using DadataApiClient.Models.Suggests.Responses;
using DadataApiClient.Models.Suggests.ShortResponses;

namespace DadataApiClient.Interfaces
{
    /// <summary>
    /// Interface for creation client of Suggestions API
    /// </summary>
    public interface IDadataSuggestionsApiClient : IDisposable
    {
        /// <summary>
        /// Get full hints for the address
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <param name="count">the number of hints, if equal to 1, then the coordinates are filled</param>
        /// <returns></returns>
        Task<DadataAddressQueryBaseResponse> SuggestionsQueryAddress(string query, int? count = null);

        /// <summary>
        /// Get short hints for the address
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <param name="count">the number of hints, if equal to 1, then the coordinates are filled</param>
        /// <returns></returns>
        Task<DadataAddressQueryShortResponse> SuggestionsShortQueryAddress(string query, int? count = null);

        /// <summary>
        /// Get full hints for the FIO
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataFioQueryBaseResponse> SuggestionsQueryFio(string query);
        
        /// <summary>
        /// Get short hints for the FIO
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataFioQueryShortResponse> SuggestionsShortQueryFio(string query);

        /// <summary>
        /// Get full hints for the organization
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataOrganizationQueryBaseResponse> SuggestionsQueryOrganization(string query);
        
        /// <summary>
        /// Get short hints for the organization
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataPartyQueryShortResponse> SuggestionsShortQueryOrganization(string query);
        
        /// <summary>
        /// Get full hints for the bank
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataBankQueryBaseResponse> SuggestionsQueryBank(string query);
        
        /// <summary>
        /// Get short hints for the bank
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataBankQueryShortResponse> SuggestionsShortQueryBank(string query);
        
        /// <summary>
        /// Get full hints for the email
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataEmailQueryBaseResponse> SuggestionsQueryEmail(string query);
        
        /// <summary>
        /// Get short hints for the email
        /// </summary>
        /// <param name="query">text to search for</param>
        /// <returns></returns>
        Task<DadataEmailQueryShortResponse> SuggestionsShortQueryEmail(string query);
    }
}