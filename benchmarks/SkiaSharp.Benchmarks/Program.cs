﻿using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace SkiaSharp.Benchmarks
{
	//[SimpleJob(RuntimeMoniker.CoreRt31)]
	[SimpleJob(RuntimeMoniker.Mono)]
	[SimpleJob(RuntimeMoniker.Net472)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.NetCoreApp50)]
	[MemoryDiagnoser]
	public unsafe class Benchmark
	{
		public Benchmark()
		{
			// setup
		}

		[Benchmark]
		public void TheBenchmark()
		{
			// benchmark
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Benchmark>();
		}
	}
}
