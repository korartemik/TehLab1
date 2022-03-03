open NuGetCreate
open System


module Immutability =


    let vertices = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10 |]
    let edges = [|Tuple.Create(1,2); Tuple.Create(1,3);
        Tuple.Create(2,4); Tuple.Create(3,5); Tuple.Create(3,6);
        Tuple.Create(4,7); Tuple.Create(5,7); Tuple.Create(5,8);
        Tuple.Create(5,6); Tuple.Create(8,9); Tuple.Create(9,10)|]

    let graph = new GraphAndAlgo.Graph<int>(vertices, edges)
    let gr = new GraphAndAlgo()
    let f = gr.BFS(graph, 1)