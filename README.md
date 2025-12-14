# NEATetris
A Neuro-Evolution of Augmented Topologies algorithm that learns to play Tetris

## Features/To-do list:
### The Tetris Engine
* Fully functional Tetris game
* Allows playing against the algorithm (side-by-side view)
* Grid view (n x n) showing the whole live population games

### The NEAT core
* Live network visualization
* Two fitness function: single game (fixed-seed network, or FSN) vs. average of N games (random-seeds network, or RSN)

### Goals and Hypotheses
Build four different networks:
1. Fixed seed network (FSN): network fitness is the score on a single fixed seed;
2. Random seeds network (RSN): network fitness is the average fitness on a set of N random seeds;
3. Randomly Varying Seeds Network (RVSN): same as RSN, but seed-set changes randomly after X generations;
4. Modularly Varying Seeds Network (MVSN): same as RSN, but seed-set changes conservatly after X generations.

Hypotheses:
1. FSNs will have amazing performance on their fixed seed, but poor performance otherwise (compared with other networks);
2. RVSNs will have poor performance on novel seeds (but probably not as poor as FSNs);
3. MVSNs will have good performance on novel seeds (probably the best compared to other networks).

My goals:
1. Build an FSN that consistently beats me on a specific seed;
2. Build an MVSN with a good overall performance (maybe similar to mine?).
