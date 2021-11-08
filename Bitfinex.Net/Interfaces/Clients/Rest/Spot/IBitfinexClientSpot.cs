﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bitfinex.Net.Enums;
using Bitfinex.Net.Objects;
using Bitfinex.Net.Objects.RestV1Objects;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;

namespace Bitfinex.Net.Interfaces.Clients.Rest.Spot
{
    /// <summary>
    /// Interface for the Bitfinex client
    /// </summary>
    public interface IBitfinexClientSpot: IRestClient
    {
        public IBitfinexClientSpotAccount Account { get; set; }
        public IBitfinexClientSpotExchangeData ExchangeData { get; set; }
        public IBitfinexClientSpotTrading Trading { get; set; }

        /// <summary>
        /// Set the API key and secret
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="apiSecret">The api secret</param>
        /// <param name="nonceProvider">Optional nonce provider for signing requests. Careful providing a custom provider; once a nonce is sent to the server, every request after that needs a higher nonce than that</param>
        void SetApiCredentials(string apiKey, string apiSecret, INonceProvider? nonceProvider = null);
    }
}