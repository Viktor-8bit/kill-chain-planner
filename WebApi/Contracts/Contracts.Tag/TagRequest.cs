﻿



namespace WebApi.Contracts;

public record TagRequest
{
    public string InstrumentName { get; set; }
    public string TagURL { get; set; }
}