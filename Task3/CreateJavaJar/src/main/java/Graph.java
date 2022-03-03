package com.exaple.graph;
import java.util.*;

public class Graph {
    private int V;
    private LinkedList<Integer> adj[];
    private boolean visited[];
    public Graph(){

    }
    // Create a graph
    public Graph(int v) {
        visited = new boolean[v];
        V = v;
        adj = new LinkedList[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new LinkedList<Integer>();
    }

    // Add edges to the graph
    public void addEdge(int v, int w) {
        adj[v].add(w);
    }
    // BFS algorithm
    public void BFS(int s) {

        boolean visited[] = new boolean[V];

        LinkedList<Integer> queue = new LinkedList();

        visited[s] = true;
        queue.add(s);

        while (queue.size() != 0) {
            s = queue.poll();
            System.out.print(s + " ");

            Iterator<Integer> i = adj[s].listIterator();
            while (i.hasNext()) {
                int n = i.next();
                if (!visited[n]) {
                    visited[n] = true;
                    queue.add(n);
                }
            }
        }
    }
    public void DFS(int vertex) {
        visited[vertex] = true;
        System.out.print(vertex + " ");

        Iterator<Integer> ite = adj[vertex].listIterator();
        while (ite.hasNext()) {
            int adj = ite.next();
            if (!visited[adj])
                DFS(adj);
        }
    }
    
}