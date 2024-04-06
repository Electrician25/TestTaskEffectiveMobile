using CommandLine;
using Microsoft.Extensions.Hosting;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Extentions;
using TestTaskEffectiveMobile.FileOntions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddFileServices();

Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileOption.Options(opts, args));
using IHost host = builder.Build();