﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.NET.Example.Jobs;

internal class DummyJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine("I am dummy.");
        return Task.CompletedTask;
    }
}
