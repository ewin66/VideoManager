﻿using System;

namespace VMModels.Model
{
    public class Snapshot
    {
        public Guid Id { get; set; }
        public string UNCName { get; set; }
        public string UNCPath { get; set; }
        public string StoredFileName { get; set; }
        public string FileExtension { get; set; }
        public DateTime? FileAddedTimestamp { get; set; }
        public int FrameNumber { get; set; }
        public byte[] Thumbnail { get; set; }
        public long FileSize { get; set; }
        public string FileHash { get; set; }
        public string GPS { get; set; }
        public Guid DataFileId { get; set; }
    }
}
