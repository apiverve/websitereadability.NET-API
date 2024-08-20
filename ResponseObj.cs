using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("fleschReadingEase")]
    public double fleschReadingEase { get; set; }

    [JsonProperty("fleschReadingEaseText")]
    public string fleschReadingEaseText { get; set; }

    [JsonProperty("fleschKincaidGrade")]
    public double fleschKincaidGrade { get; set; }

    [JsonProperty("gunningFog")]
    public double gunningFog { get; set; }

    [JsonProperty("colemanLiauIndex")]
    public double colemanLiauIndex { get; set; }

    [JsonProperty("smogIndex")]
    public double smogIndex { get; set; }

    [JsonProperty("automatedReadabilityIndex")]
    public double automatedReadabilityIndex { get; set; }

    [JsonProperty("daleChallReadabilityScore")]
    public double daleChallReadabilityScore { get; set; }

    [JsonProperty("daleChallReadabilityScoreText")]
    public string daleChallReadabilityScoreText { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
