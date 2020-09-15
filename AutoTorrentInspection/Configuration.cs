﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Jil;

namespace AutoTorrentInspection
{
    public class GlobalConfiguration
    {
        private static Configuration _instance;

        private const string ConfigFile = "config.json";

        protected GlobalConfiguration() {}

        public static Configuration Instance(bool reload = false)
        {
            if (_instance == null || reload)
            {
                try
                {
                    using (var input = new StreamReader(ConfigFile))
                    {
                        _instance = JSON.Deserialize<Configuration>(input);
                        Logger.Log("Load configuration file success");
                    }
                }
                catch (Exception exception)
                {
                    Logger.Log(exception);
                    _instance = new Configuration();
                }
            }
            return _instance;
        }
    }

    public class Configuration
    {
        public int Version = 2;
        public Naming Naming = new Naming();
        public RowColor RowColor = new RowColor();
        public InspectionOptions InspectionOptions = new InspectionOptions();
        public string[] TrackerList = {
            "http://208.67.16.113:8000/annonuce",
            "udp://208.67.16.113:8000/annonuce",
            "udp://tracker.openbittorrent.com:80/announce",
            "http://t.acg.rip:6699/announce",
            "http://nyaa.tracker.wf:7777/announce",
            "https://tr.bangumi.moe:9696/announce",
            "http://tr.bangumi.moe:6969/announce",
            "udp://tr.bangumi.moe:6969/announce",
            "http://open.acgnxtracker.com/announce",
            "https://open.acgnxtracker.com/announce"
        };

        public ASS ASS = new ASS();

        public override string ToString()
        {
            return JSON.Serialize(this, new Options(true));
        }
    }

    public class Naming
    {
        public Pattern Pattern = new Pattern();
        public Extension Extension = new Extension();
        public string[] UnexpectedCharacters = { "\u3099", "\u309a" };
    }

    public class Pattern
    {
        public string VCBS  = @"^\[[^\[\]]*VCB\-S(?:tudio)?[^\[\]]*\] [^\[\]]+ (?:\[[^\[\]]*\d*\])?\[(?:(?:(?:(?:Hi10p|Hi444pp)_(?:2160|1080|816|720|576|480)p\]\[x264)|(?:(?:Ma10p_(?:2160|1080|816|720|576|480)p\]\[x265)))(?:_\d*(?:flac|aac|ac3|dts))+\](?:\.(?:mkv|mka|flac))?|(?:(?:1080|816|720|576)p\]\[(?:x264|x265)_(?:aac|ac3|dts)\](?:\[[st]c\]\.mp4)?))(?:(?<!(?:mkv|mka|mp4))(?:\.(?:[SsTt]c|[Cc]h(?:s|t)|[Jj](?:pn|ap)|[Cc]h(?:s|t)&[Jj](?:pn|ap)))?\.ass)?$";
        public string MENU  = @"^\[[^\[\]]*VCB\-S(?:tudio)*[^\[\]]*\] [^\[\]]+ \[[^\[\]]*\]\.png$";
        public string CD    = @"^\[\d{6}\] (?<title>(?:｢[^｢｣\[\]\(\)／]+｣)|(?:[^\[\]\(\)／]+))(?:／(?<artist>[^｢｣\[\]\(\)]+))? (?<hi_res>\[\d{2}bit_\d{2}kHz\])? ?(?<content>\((?:\+?(?:flac|tak|alac|mp3|webp|jpg))+\))$";
        [JilDirective(Ignore = true)]
        public string FCH   = @"^(?:\[(?:[^\[\]])*philosophy\-raws(?:[^\[\]])*\])\[[^\[\]]+\]\[(?:(?:[^\[\]]+\]\[(?:BDRIP|DVDRIP|BDRemux))|(?:(?:BDRIP|DVDRIP|BDRemux)(?:\]\[[^\[\]]+)?))\]\[(?:(?:(?:HEVC )?Main10P)|(?:(?:AVC )?Hi10P)|Hi444PP|H264) \d*(?:FLAC|AC3)\]\[(?:(?:(?:1920|1440)[Xx]1080)|(?:1280[Xx]720)|(?:1024[Xx]576)|(?:720[Xx]480))\](?:(?:\.(?:sc|tc|chs|cht))?\.ass|(?:\.(?:mkv|mka|flac)))$";
        [JilDirective(Ignore = true)]
        public string MAWEN = @"^[^\[\]]+ \[(?:BD|BluRay|BD\-Remux|SPDVD|DVD) (?:1920x1080p?|1280x720p?|720x480p?|1080p|720p|480p)(?: (?:23\.976|24|25|29\.970|59\.940)fps)?(?: vfr)? (?:(?:(?:AVC|HEVC)\-(?:Lossless-)?(?:yuv420p10|yuv420p8|yuv444p10))|(?:x264(?:-Hi(?:10|444P)P)?|x265-Ma10P))(?: (?:FLAC|AAC|AC3)(?:x\d)?)+(?: (?:Chap|Ordered\-Chap))?\](?: v\d)? - (?:[^\.&]+ ?& ?)*mawen1250(?: ?& ?[^\.&]+)*(?:(?:\.(?:sc|tc|chs|cht))?\.ass|(?:\.(?:mkv|mka|flac)))$";
    }

    public class Extension
    {
        public string[] AudioExtensions = {"flac", "tak", "m4a", "cue", "log"};
        [JilDirective(Ignore = true)]
        public Regex AudioExtension => new Regex($@"\.{string.Join("|", AudioExtensions)}$", RegexOptions.IgnoreCase);

        public string[] ImageExtensions = {"jpg", "jpeg", "jp2", "webp"};
        [JilDirective(Ignore = true)]
        public Regex ImageExtension => new Regex($@"\.{string.Join("|", ImageExtensions)}$", RegexOptions.IgnoreCase);

        public string[] ExceptExtensions = {"rar", "7z", "zip"};
        [JilDirective(Ignore = true)]
        public Regex ExceptExtension => new Regex($@"\.{string.Join("|", ExceptExtensions)}$", RegexOptions.IgnoreCase);
    }

    public class RowColor
    {
        public string INVALID_FILE           = "fffb9966";
        public string VALID_FILE             = "ff92aaf3";
        public string INVALID_CUE            = "ffff6538";
        public string INVALID_ENCODE         = "ff51559b";
        public string INVALID_PATH_LENGTH    = "ffff0a32";
        public string INVALID_FLAC_LEVEL     = "ffcfd8dc";
        public string NON_UTF_8_W_BOM        = "fffbbc05";
        public string INVALID_FILE_SIGNATURE = "ff009933";
        public string INVALID_CD_FOLDER      = "ff0559ae";
        public string TAMPERED_LOG           = "ff8b4513";
    }

    public class InspectionOptions
    {
        public bool WebPPosition = false;
        public bool CDNaming = true;
        public bool FileHeader = true;
        public bool FLACCompressRate = true;
        public bool CUEEncoding = true;
        public bool LogValidation = false;
    }

    public class ASS
    {
        public string[] UnexpectedTags = { "1img", "2img", "3img", "4img", "1vc", "2vc", "3vc", "4vc", "1va", "2va", "3va", "4va", "distort", "frs", "fsvp", "jitter", "mover", "moves3", "moves4", "movevc", "rndx", "rndy", "rndz", "rnds", "rnd", "z" };
    }
}
