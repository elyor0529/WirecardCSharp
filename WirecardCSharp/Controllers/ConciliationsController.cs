﻿using Newtonsoft.Json;
using System.Net.Http;
using WirecardCSharp.Models;
using System.Threading.Tasks;
using WirecardCSharp.Exception;

namespace WirecardCSharp.Controllers
{
    //Conciliações - Conciliations
    public partial class ConciliationsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static ConciliationsController instance = null;
        internal static ConciliationsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ConciliationsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// Obter Arquivo de Vendas - Get Sales File
        /// </summary>
        /// <param name="date">Data no formato YYYYMMDD</param>
        /// <returns></returns>
        public async Task<SalesFileResponse> GetSalesFile(string date)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/sales/{date}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SalesFileResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obter Arquivo Financeiro - Get Financial File
        /// </summary>
        /// <param name="eventsCreatedAt">Data referente à liquidação dos lançamentos financeiros. Formato: YYYY-MM-DD</param>
        /// <returns></returns>
        public async Task<string> GetFinancialFile(string eventsCreatedAt)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/financials?eventsCreatedAt={eventsCreatedAt}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}