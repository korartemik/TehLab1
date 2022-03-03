package benchmarks;

import func.MergeSort;
import func.QuickSort;
import org.openjdk.jmh.annotations.*;
import org.openjdk.jmh.profile.GCProfiler;
import org.openjdk.jmh.profile.Profiler;
import org.openjdk.jmh.runner.Runner;
import org.openjdk.jmh.runner.RunnerException;
import org.openjdk.jmh.runner.options.Options;
import org.openjdk.jmh.runner.options.OptionsBuilder;

import java.lang.management.MemoryUsage;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

@BenchmarkMode(Mode.AverageTime)
@State(Scope.Benchmark)
public class bench {

    int n = 100000;
    public ArrayList<Integer> list = new ArrayList<Integer>();
    private int [] mas1 = new int[n];
    private int [] mas2 = new int[n];

    public static void main(String[] args) throws RunnerException{
        Options opt = new OptionsBuilder()
                .include(bench.class.getSimpleName())
                .forks(1)
                .addProfiler(GCProfiler.class)
                .build();
        new Runner(opt).run();
    }


    @Setup
    public void setup() {
        Random rnd = new Random();
        for(int i = 0; i < n; i++){
            int x = rnd.nextInt();
            mas1[i]=x;
            mas2[i]=x;
            list.add(x);
        }

    }

    @Benchmark
    public void defaultSort() {
        Collections.sort(list);
    }

    @Benchmark
    public void mergeSort() {
        MergeSort.mergeSort(mas1, mas1.length);
    }

    @Benchmark
    public void quickSort() {
        QuickSort.quickSort(mas2, 0, mas2.length-1);
    }
}
