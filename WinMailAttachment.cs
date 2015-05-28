using System;

namespace WinMailParser
{
    /// <summary>
    /// TNEFAttachment
    /// 
    /// Based on tnef.c from Thomas Boll 
    /// </summary>
    public class WinMailAttachment
    {
        #region Properties
        /// <summary>
        /// attachment subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// attachment file length
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// attachment file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// attachment file content
        /// </summary>
        public byte[] Content { get; set; }
        #endregion

        public WinMailAttachment()
        {
            Content = null;
            FileName = "";
            Subject = "";
        }
    }
}