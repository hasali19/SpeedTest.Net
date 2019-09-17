﻿using SpeedTest.Models;
using System.Threading.Tasks;

namespace SpeedTest
{
    public interface ISpeedTestClient
    {
        /// <summary>
        /// Download speedtest.net settings
        /// </summary>
        /// <returns>speedtest.net settings</returns>
        Task<Settings> GetSettingsAsync();

        /// <summary>
        /// Test latency (ping) to server
        /// </summary>
        /// <returns>Latency in milliseconds (ms)</returns>
        Task<int> TestServerLatencyAsync(Server server, int retryCount = 3);

        /// <summary>
        /// Test download speed to server
        /// </summary>
        /// <returns>Download speed in Kbps</returns>
        Task<double> TestDownloadSpeedAsync(Server server, int simultaniousDownloads = 2, int retryCount = 2);

        /// <summary>
        /// Test upload speed to server
        /// </summary>
        /// <returns>Upload speed in Kbps</returns>
        Task<double> TestUploadSpeedAsync(Server server, int simultaniousUploads = 2, int retryCount = 2);
    }
}