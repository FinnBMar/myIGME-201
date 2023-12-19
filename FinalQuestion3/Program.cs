using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalExamQuestion3
{
    public enum EColorState
    {
        RED,
        BLUE,
        GRAY,
        CYAN,
        YELLOW,
        ORANGE,
        PURPLE,
        GREEN
    }

    public class Node : IComparable<Node>
    {
        public EColorState colorState;

        public List<Edge> edges = new List<Edge> ();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(EColorState eColorState)
        {
            this.colorState = eColorState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node other)
        {
            return this.minCostToStart.CompareTo(other.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge other)
        {
            return this.cost.CompareTo(other.cost);
        }
    }

    internal class Program
    {
        //QUESTION 3
        static int[,] mGraph = new int[,]
        {
                            // RED   BLUE   GRAY   CYAN   YELLOW  ORANGE  PURPLE GREEN
            /* RED */       { -1   , 1    , 5   , -1    , -1    , -1   , -1   , -1 },
            /* BLUE */      { -1   , -1   , -1   , 1    , 8     , -1   , -1   , -1 },
            /* GRAY */      { -1   , 1    , -1   , 0    , -1    ,  1   , -1   , -1 },
            /* CYAN */      { -1   , 1    , 1   , -1   , -1    , -1   , -1   , -1 },
            /* YELLOW */    { -1   , -1    , -1   , -1   , -1    , -1   , -1   , 6 },
            /* ORANGE */    { -1   , -1    , -1   , -1   , -1    , -1   , 1   , -1 },
            /* PURPLE */    { -1   , -1    , -1   , -1   , 1    , -1   , -1   , -1 },
            /* GREEN */     { -1   , -1    , -1   , -1   , -1    , -1   , -1   , -1 }

        };

        //QUESTION 3
        static EColorState[][] lGraph = new EColorState[][]
        {
            /* RED */    new EColorState[] { EColorState.BLUE, EColorState.GRAY },
            /* BLUE */   new EColorState[] { EColorState.CYAN, EColorState.YELLOW },
            /* GRAY */   new EColorState[] { EColorState.CYAN, EColorState.ORANGE },
            /* CYAN */   new EColorState[] { EColorState.BLUE, EColorState.GRAY },
            /* YELLOW */ new EColorState[] { EColorState.GREEN },
            /* ORANGE */ new EColorState[] { EColorState.PURPLE},  
            /* PURPLE */ new EColorState[] { EColorState.YELLOW },
            /* GREEN */  new EColorState[0]
        };

        //QUESTION 3
        static int[][] wGraph = new int[][]
        {
            /* RED */    new int[] { -1, 1, 5, -1, -1, -1, -1, -1 },
            /* BLUE */   new int[] { -1, -1, -1, 1, 8, -1, -1, -1 },
            /* GRAY */   new int[] { -1, 1, -1, 0, -1, 1, -1, -1 },
            /* CYAN */   new int[] { -1, 1, 1, -1, -1, -1, -1, -1 },
            /* YELLOW */ new int[] { -1, -1, -1, -1, -1, -1, -1, 6 },
            /* ORANGE */ new int[] { -1, -1, -1, -1, -1, -1, 1, -1 },
            /* PURPLE */ new int[] { -1, -1, -1, -1, 1, -1, -1, -1 },
            /* GREEN */  new int[] { -1, -1, -1, -1, -1, -1, -1, -1 }
        };

        static int nState = 0;

        static List<Node> graph = new List<Node>();

        static void Main(string[] args)
        {
            Random rand = new Random();
            string sState = null;
            Node node;
            node = new Node(EColorState.RED);
            graph.Add(node);

            node = new Node(EColorState.BLUE);
            graph.Add(node);

            node = new Node(EColorState.GRAY);
            graph.Add(node);

            node = new Node(EColorState.CYAN);
            graph.Add(node);

            node = new Node(EColorState.YELLOW);
            graph.Add(node);

            node = new Node(EColorState.ORANGE);
            graph.Add(node);

            node = new Node(EColorState.PURPLE);
            graph.Add(node);

            node = new Node(EColorState.GREEN);
            graph.Add(node);

            graph[(int)EColorState.RED].AddEdge(1, graph[(int)EColorState.BLUE]);
            graph[(int)EColorState.RED].AddEdge(5, graph[(int)EColorState.GRAY]);
            graph[(int)EColorState.RED].edges.Sort();

            graph[(int)EColorState.BLUE].AddEdge(1, graph[(int)EColorState.CYAN]);
            graph[(int)EColorState.BLUE].AddEdge(8, graph[(int)EColorState.YELLOW]);
            graph[(int)EColorState.BLUE].edges.Sort();

            graph[(int)EColorState.GRAY].AddEdge(0, graph[(int)EColorState.CYAN]);
            graph[(int)EColorState.GRAY].AddEdge(1, graph[(int)EColorState.ORANGE]);
            graph[(int)EColorState.GRAY].edges.Sort();

            graph[(int)EColorState.CYAN].AddEdge(1, graph[(int)EColorState.BLUE]);
            graph[(int)EColorState.CYAN].AddEdge(0, graph[(int)EColorState.GRAY]);
            graph[(int)EColorState.CYAN].edges.Sort();

            graph[(int)EColorState.YELLOW].AddEdge(6, graph[(int)EColorState.GREEN]);
            graph[(int)EColorState.YELLOW].edges.Sort();

            graph[(int)EColorState.ORANGE].AddEdge(1, graph[(int)EColorState.PURPLE]);
            graph[(int)EColorState.ORANGE].edges.Sort();

            graph[(int)EColorState.PURPLE].AddEdge(1, graph[(int)EColorState.YELLOW]);
            graph[(int)EColorState.PURPLE].edges.Sort();

            //QUESTION 5
            List<Node> shortestPath = DijkstrasPath();

            Console.WriteLine("Dijkstra's Shortest Path: ");
            for(int i = 0; i < shortestPath.Count; i++)
            {
                Console.WriteLine(shortestPath[i].colorState);
            }

            Console.WriteLine();

            //QUESTION 4
            while (true)
            {
                nState = rand.Next(0, Enum.GetNames(typeof(EColorState)).Length);

                if (nState != (int)EColorState.GREEN)
                {
                    break;
                }
            }

            Thread t = new Thread(DFS);
            t.Start();

        
        }
//------------------------------------- Depth First Search -------------------------------------------------- 
        //QUESTION 4
        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            Console.WriteLine("DFS: ");

            for(int i = 0; i < lGraph.Length; i++)
            {
                if (!visited[i])
                {
                    DFSUtil((EColorState)i, visited);
                }
            }

            
        }

        //QUESTION 4
        static void DFSUtil(EColorState v, bool[] visited)
        {
            visited[(int)v] = true;

            Console.WriteLine(v.ToString() + " ");

            EColorState[] thisStateList = lGraph[(int)v];
            if (thisStateList != null)
            {
                foreach (EColorState n in thisStateList)
                {
                    if (!visited[(int)n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }

//------------------------------------- Dijkstra's Shortest Path --------------------------------------------------        
        //QUESTION 5
        static public List<Node> DijkstrasPath()
        {
            // traverse the path and calculate the minCostToStart and nearestToStart
            DijkstraSearch();

            List<Node> shortestPath = new List<Node>();

            // start from the end
            shortestPath.Add(graph[(int)EColorState.GREEN]);

            // recursively traverse from finish to start
            BuildShortestPath(shortestPath, graph[(int)EColorState.GREEN]);

            // reverse the path
            shortestPath.Reverse();

            // return the shortest path
            return (shortestPath);
        }

        //QUESTION 5
        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        //QUESTION 5
        static int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        //QUESTION 5
        static private void DijkstraSearch()
        {
            Node start = graph[(int)EColorState.RED];

            start.minCostToStart = 0;

            List<Node> queue = new List<Node>();
            queue.Add(start);

            // 2 ways to point our delegate variable to a delegate method
            Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            //Func<Node, int> nodeOrderBy = NodeOrderBy;

            // stay in this loop while we have items in our queue
            do
            {
                // sort our queue by minCostToStart
                // option #1, use .Sort() which sorts in place
                queue.Sort();

                //use .OrderBy() with a delegate method 
                queue = queue.OrderBy(nodeOrderBy).ToList();
                queue = queue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => n.minCostToStart).ToList();
                queue = queue.OrderBy(n => n.minCostToStart).ToList();

                // grab the first node from our sorted queue
                Node node = queue.First();

                // remove it
                queue.Remove(node);

                // look at each edge and calculate the minCostToStart for each neighbor
                foreach (Edge cnn in node.edges)
                {
                    Node neighborNode = cnn.connectedNode;

                    if (neighborNode.visited)
                    {
                        continue;
                    }

                    // check if the path from this neighbor to the start is shorter if passing through this node
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // if it is then set this node as being nearest to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;
                        neighborNode.nearestToStart = node;

                        // and add this neighbor to the queue
                        if (!queue.Contains(neighborNode))
                        {
                            queue.Add(neighborNode);
                        }
                    }
                }

                // set this node as being visited
                node.visited = true;

                // if we reached the target, then its done
                if (node == graph[(int)EColorState.GREEN])
                {
                    return;
                }

            } while (queue.Any());
        }
        
    }
}
