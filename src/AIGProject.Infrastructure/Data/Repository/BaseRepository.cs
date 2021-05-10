using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace AIGProject.Infrastructure.Data.Repository 
{
    public class BaseRepository<R>
    {
        private IConfiguration _config;
        private readonly ILogger<R> _logger;

        public BaseRepository(IConfiguration configuration, ILogger<R> logger)
        {
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _ = logger ?? throw new ArgumentNullException(nameof(logger));

            _config = configuration;
            _logger = logger;
        }


        public List<T> Query<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    return conn.Query<T>(query, parameters).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public T QueryFirst<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    return conn.QueryFirst<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public T QueryFirstOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    return conn.QueryFirstOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public T QuerySingle<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    return conn.QuerySingle<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public T QuerySingleOrDefault<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    return conn.QuerySingleOrDefault<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        public void Execute(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_config["ConnectionStrings:DefaultConnection"]))
                {
                    conn.Execute(query, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Sets access token for using a managed identity for azure resources
        /// </summary>
        /// <param name="conn"></param>
        //private void SetAzureAccessToken(SqlConnection conn)
        //{
        //    if (!Debugger.IsAttached)
        //    {
        //        var credential = new DefaultAzureCredential();
        //        var token = credential.GetToken(new Azure.Core.TokenRequestContext(new[] { "https://database.windows.net/" }));
        //        conn.AccessToken = token.Token;
        //    }
        //}


    }
}