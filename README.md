# Blind Top 75 LeetCode Problems - in CSharp

Originally posted [New Year Gift - Curated List of Top 75 LeetCode Questions to Save Your Time](https://www.teamblind.com/post/New-Year-Gift---Curated-List-of-Top-75-LeetCode-Questions-to-Save-Your-Time-OaM1orEU) as a curated list of the top 75 questions to understand when preparing for a FAANGMULA+ interview.

## Approach

5 weeks of [LeetCode](https://leetcode.com/) questions broken into categories: sequences, data structures, non-linear data structures, more data structures, and finally dynamic programming as organized [here](https://www.techinterviewhandbook.org/best-practice-questions/).

### Week 1 - Sequences

In week 1, we will warm up by doing a mix of easy and medium questions on arrays and strings. Arrays and strings are the most common types of questions to be found in interviews; gaining familiarity with them will help in building strong fundamentals to better handle tougher questions.

| Question                                                                                          | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                                | Category         | Revisit |
| ------------------------------------------------------------------------------------------------- | ---------- | :-------------------------------: | ----------------------------------------------------------------------- | ---------------- | :-----: |
| [Two Sum](https://leetcode.com/problems/two-sum/)                                                 | Easy       | [🚀](https://youtu.be/KLlXCFG5TnA) | [TwoSummer](./Blind75CSharp/Week01/TwoSummer.cs)                        | Arrays & Hashing |         |
| [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)                           | Easy       | [🚀](https://youtu.be/3OamzN90kPg) | [ContainsDuplicater](./Blind75CSharp/Week01/ContainsDuplicater.cs)      | Arrays & Hashing |         |
| [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy       | [🚀](https://youtu.be/1pkOgXD63yU) | [BuySellStock](./Blind75CSharp/Week01/BuySellStock.cs)                  | Sliding Window   |         |
| [Valid Anagram](https://leetcode.com/problems/valid-anagram/)                                     | Easy       | [🚀](https://youtu.be/9UtInBqnCgA) | [Anagram](./Blind75CSharp/Week01/Anagram.cs)                            | Strings          |         |
| [Valid Parentheses](https://leetcode.com/vproblems/valid-parentheses/)                            | Easy       | [🚀](https://youtu.be/WTzjTskDFMg) | [ValidParentheses](./Blind75CSharp/Week01/ValidParentheses.cs)          | Strings          |         |
| [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/)                               | Easy       | [🚀](https://youtu.be/5WZl3MMT0Eg) | [MaxSubArrayFinder](./Blind75CSharp/Week01/MaxSubArrayFinder.cs)        | Sliding Window   |    Y    |
| [Product of Array Except Self](https://leetcode.com/problems/maximum-product-subarray/)           | Medium     | [🚀](https://youtu.be/bNvIQI2wAjk) | [ProductExceptSelf](./Blind75CSharp/Week01/ProductOfArrayExceptSelf.cs) | Arrays & Hashing |    Y    |
| [3Sum](https://leetcode.com/problems/3sum/)                                                       | Medium     | [🚀](https://youtu.be/jzZsG8n2R9A) | [3Summer](./Blind75CSharp/Week01/ThreeSummer.cs)                        | Arrays & Hashing |         |
| [Merge Intervals](https://leetcode.com/problems/merge-intervals/)                                 | Medium     | [🚀](https://youtu.be/44H3cEC2fFM) | [Intervals](./Blind75CSharp/Week01/Intervals.cs)                        | Intervals        |         |
| [Group Anagrams](https://leetcode.com/problems/group-anagrams/)                                   | Medium     | [🚀](https://youtu.be/vzdNOK2oB2E) | [GroupAnagram](./Blind75CSharp/Week01/GroupAnagram.cs)                  | Strings          |         |
| **BONUS**                                                                                         | **---**    |               **🙌🏻**               | **---**                                                                 | **---**          | **---** |
| [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)               | Medium     | [🚀](https://youtu.be/lXVy6YWFcRM) | [MaxSubArrayFinder](./Blind75CSharp/Week01/MaxSubArrayFinder.cs)        | DP               | YES!!!  |
| [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/)   | Medium     | [🚀](https://youtu.be/U8XENwh8Oy8) | [SearchRotatedArray](./Blind75CSharp/Week01/SearchRotatedArray.cs)      | Binary Search    |    Y    |
| [Two Sum II - Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/)            | Medium     | [🚀](https://youtu.be/cQ1Oz4ckceM) | [TwoSummer](./Blind75CSharp/Week01/TwoSummer.cs)                        | Double Pointers  |         |
| [Insert Interval](https://leetcode.com/problems/insert-interval/)                                 | Medium     | [🚀](https://youtu.be/A8NUOmlwOlM) | [Intervals](./Blind75CSharp/Week01/Intervals.cs)                        | Intervals        |    Y    |

### Week 2 - Data structures

The focus of week 2 is on linked lists, strings and matrix-based questions. The goal is to learn the common routines dealing with linked lists, traversing matrices and sequence analysis (arrays/strings) techniques such as sliding window, linked list traversal and matrix traversal.

| Question                                                                                                                        | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                            | Category        | Revisit |
| ------------------------------------------------------------------------------------------------------------------------------- | ---------- | :-------------------------------: | ------------------------------------------------------------------- | --------------- | :-----: |
| [Detect Cycle in a Linked List](https://leetcode.com/problems/linked-list-cycle/)                                               | Easy       |                 🤷🏻‍♂️                 | [HasCycle](./Blind75CSharp/Week02/Solution02.cs.cs)                 | Linked Lists    |         |
| [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/)                     | Medium     |                 🤷🏻‍♂️                 | [SearchRotatedArray](./Blind75CSharp/Week01/SearchRotatedArray.cs)  | Double Pointers |         |
| [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)                                           | Medium     | [🚀](https://youtu.be/UuiTKBwPgAo) | [MaxArea](./Blind75CSharp/Week02/Solution02.cs)                     | Double Pointers |         |
| [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)               | Medium     | [🚀](https://youtu.be/gqXU1UyA8pk) | [CharacterReplacement](./Blind75CSharp/Week02/LetterReplacement.cs) | Double Pointers |         |
| [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium     |                 🤷🏻‍♂️                 | [LengthOfLongestSubstring](./Blind75CSharp/Week02/Solution02.cs)    | Double Pointers |         |
| [Number of Islands](https://leetcode.com/problems/number-of-islands/)                                                           | Medium     |                 🤷🏻‍♂️                 | [NumIslands](./Blind75CSharp/Week02/Solution02.cs)                  | Graph           |         |
| [Remove Nth Node From End Of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/)                             | Medium     | [🚀](https://youtu.be/XVuQxVej6y8) | [RemoveNthFromEnd](./Blind75CSharp/Week02/Solution02.cs)            | Linked Lists    |         |
| [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/)                                                 | Medium     | [🚀](https://youtu.be/4RACzI5-du8) | [CountSubstrings](./Blind75CSharp/Week02/Solution02.cs)             | Double Pointers |         |
| [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/)                                       | Medium     | [🚀](https://youtu.be/s-VkcjHqkGI) | [PacificAtlantic](./Blind75CSharp/Week02/Solution02.cs)             | Graph           |         |
| [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)                                             | Hard       | [🚀](https://youtu.be/jSto0O4AJbM) | [MinWindow](./Blind75CSharp/Week02/Solution02.cs)                   | Sliding Window  |         |
| **BONUS**                                                                                                                       | **---**    |               **🙌🏻**               | **---**                                                             | **---**         | **---** |
| [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream/)                                     | Hard       | [🚀](https://youtu.be/itmhHWaHupI) | [MedianFinder.cs](./Blind75CSharp/Week02/MedianFinder.cs)           | Data Structures |         |
| [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree/)                                       | Medium     | [🚀](https://youtu.be/oobqoCJlHA0) | [Trie.cs](./Blind75CSharp/Week02/Trie.cs)                           | Data Structures |         |

### Week 3 - Non-linear data structures

The focus of week 3 is on non-linear data structures like trees, graphs and heaps. You should be familiar with the various tree traversal (in-order, pre-order, post-order) algorithms and graph traversal algorithms such as breadth-first search and depth-first search. In my experience, using more advanced graph algorithms (Dijkstra's and Floyd-Warshall) is quite rare and usually not necessary.

| Question                                                                                                                                              | Difficulty |  [NeetCode](https://neetcode.io/)  | Solution                                                      | Category | Revisit |
| ----------------------------------------------------------------------------------------------------------------------------------------------------- | ---------- | :--------------------------------: | ------------------------------------------------------------- | -------- | :-----: |
| [Invert/Flip Binary Tree](https://leetcode.com/problems/invert-binary-tree/)                                                                          | Easy       |                 🤷🏻‍♂️                  | [InvertTree](./Blind75CSharp/Week03/Solution03.cs)            |          |         |
| [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/)                                                             | Medium     |                 🤷🏻‍♂️                  | [IsValidBST](./Blind75CSharp/Week03/Solution03.cs)            |          |         |
| [Non-overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/)                                                                 | Medium     |                 🤷🏻‍♂️                  | [EraseOverlapIntervals](./Blind75CSharp/Week03/03.cs)         |          |         |
| [Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/) | Medium     |                 🤷🏻‍♂️                  | [TODO](./Blind75CSharp/Week03/Solution03.cs)                  |          |         |
| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/)                                                                     | Medium     |                 🤷🏻‍♂️                  | [TopKFrequentUsingHeap](./Blind75CSharp/Week03/Solution03.cs) |          |         |
| [Clone Graph](https://leetcode.com/problems/clone-graph/)                                                                                             | Medium     |                 🤷🏻‍♂️                  | [CloneGraph.cs](./Blind75CSharp/Week03/CloneGraph.cs)         |          |         |
| [Course Schedule](https://leetcode.com/problems/course-schedule/)                                                                                     | Medium     |                 🤷🏻‍♂️                  | [CourseSchedule.cs](./Blind75CSharp/Week03/CourseSchedule.cs) |          |         |
| [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/)                                         | **Hard**   |                 🤷🏻‍♂️                  |                                                               |          |         |
| [Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/)                                                           | **Hard**   |                 🤷🏻‍♂️                  |                                                               |          |         |
| **BONUS**                                                                                                                                             | **---**    |               **🙌🏻**                | **---**                                                       | **---**  | **---** |
| [Graph Valid Tree](https://leetcode.com/problems/graph-valid-tree/)                                                                                   | Medium     | [🚀](https://youtu.be/bXsUuownnoQ)  | [ValidTree](./Blind75CSharp/Week03/Solution03.cs)             | Graph    |         |
| [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum/)                                                               | Medium     | [🚀](https://youtu.be/IsvocB5BJhw ) | [CanPartition](./Blind75CSharp/Week03/Solution03.cs)          | Meta     |         |

### Week 4 - More data structures

Week 4 builds up on knowledge from previous weeks but questions are of increased difficulty. Expect to see such level of questions during interviews. You get more practice on more advanced data structures such as (but not exclusively limited to) heaps and tries which are less common but are still asked.

| Question                                                                                                                                         | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                      | Category        | Revisit |
| ------------------------------------------------------------------------------------------------------------------------------------------------ | ---------- | :-------------------------------: | ------------------------------------------------------------- | --------------- | :-----: |
| [Subtree of Another Tree](https://leetcode.com/problems/subtree-of-another-tree/)                                                                | Easy       |                 🤷🏻‍♂️                 | [IsSubtree](./Blind75CSharp/week04/Solution04.cs)             | BST             |         |
| [Lowest Common Ancestor of BST](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/)                                   | Easy       |                 🤷🏻‍♂️                 |                                                               | BST             |         |
| [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree/)                                                        | Medium     | [🚀](https://youtu.be/oobqoCJlHA0) | [Trie.cs](./Blind75CSharp/Week02/Trie.cs)                     | Data Structures |         |
| [Add and Search Word](https://leetcode.com/problems/add-and-search-word-data-structure-design/)                                                  | Medium     |                 🤷🏻‍♂️                 | [WordDictionary.cs](./Blind75CSharp/Week04/WordDictionary.cs) | Trie + DFS      |         |
| [Kth Smallest Element in a BST](https://leetcode.com/problems/kth-smallest-element-in-a-bst/)                                                    | Medium     |                 🤷🏻‍♂️                 | [KthSmallest](./Blind75CSharp/week04/Solution04.cs)           | Tree            |         |
| [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/)                                                                      | **Hard**   |                 🤷🏻‍♂️                 |                                                               |                 |         |
| [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream/)                                                      | **Hard**   |                 🤷🏻‍♂️                 |                                                               |                 |         |
| [Insert Interval](https://leetcode.com/problems/insert-interval/)                                                                                | Medium     |                 🤷🏻‍♂️                 | [Insert](./Blind75CSharp/week04/Solution04.cs)                |                 |         |
| [Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/)                                                      | Medium     |                 🤷🏻‍♂️                 | [LongestConsecutive](./Blind75CSharp/week04/Solution04.cs)    |                 |         |
| [Word Search II](https://leetcode.com/problems/word-search-ii/)                                                                                  | **Hard**   | [🚀](https://youtu.be/asbcE9mZz_U) | [WordSearchII](./Blind75CSharp/week04/WordSearchII.cs)        | DP              |    ?    |
| **BONUS**                                                                                                                                        | **---**    |               **🙌🏻**               | **---**                                                       | **---**         | **---** |
| [Meeting Rooms](https://leetcode.com/problems/meeting-rooms/)`*`                                                                                 | Easy       |                 🤷🏻‍♂️                 | [CanAttendMeetings](./Blind75CSharp/week04/Solution04.cs)     | Intervals       |         |
| [Meeting Rooms 2](https://leetcode.com/problems/meeting-rooms-ii/)`*`                                                                            | Medium     |                 🤷🏻‍♂️                 | [MinMeetingRooms](./Blind75CSharp/week04/Solution04.cs)       | Intervals       |  **Y**  |
| [Number of Connected Components in an Undirected Graph](https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/)`*` | Medium     |                 🤷🏻‍♂️                 | [CountComponents](./Blind75CSharp/week04/Solution04.cs)       | Graph           |         |
| [Alien Dictionary](https://leetcode.com/problems/alien-dictionary/)`*`                                                                           | **Hard**   |                 🤷🏻‍♂️                 | [AlienOrder](./Blind75CSharp/week04/Solution04.cs)            | Kahn TopSort    |         |
| [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/)                                                                              | Easy       |                 🤷🏻‍♂️                 | [IsPalindrome](./Blind75CSharp/week04/Solution04.cs)          |                 |         |
| [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/)                                                    | Medium     |                 🤷🏻‍♂️                 | [LongestPalindrome](./Blind75CSharp/week04/Solution04.cs)     |                 |         |

### Week 5 - Dynamic programming

Week 5 focuses on Dynamic Programming (DP) questions. Personally as an interviewer, I'm not a fan of DP questions as they are not really applicable to practical scenarios and frankly if I were made to do the tough DP questions during my interviews I'd not have gotten the job. However, companies like Google still ask DP questions and if joining Google is your dream, DP is unavoidable.

DP questions can be hard to master and the best way to get better at them is... you guessed it - practice! Be familiar with the concepts of memoization and backtracking.

Practically speaking the return of investment (ROI) on studying and practicing for DP questions is very low. Hence DP questions are less important/optional and you should only do them if you have time to spare and you're very keen to have all bases covered (and interviewing with Google).

| Question                                                                                        | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                 | Category    |
| ----------------------------------------------------------------------------------------------- | ---------- | :-------------------------------: | -------------------------------------------------------- | ----------- |
| [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/)                               | Easy       |                 🤷🏻‍♂️                 | [ClimbStairs](./Blind75CSharp/Week05/Solution05.cs)      | DP          |
| [Coin Change](https://leetcode.com/problems/coin-change/)                                       | Medium     | [🚀](https://youtu.be/H9bfqozjoqs) | [CoinChange](./Blind75CSharp/Week05/Solution05.cs)       | DP          |
| [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/) | Medium     |                 🤷🏻‍♂️                 | [LengthOfLIS](./Blind75CSharp/Week05/Solution05.cs)      | DP          |
| [Combination Sum](https://leetcode.com/problems/combination-sum-iv/)                            | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| [House Robber](https://leetcode.com/problems/house-robber/)                                     | Medium     | [🚀](https://youtu.be/73r3KWiEvyk) | [HouseRobber.cs](./Blind75CSharp/Week05/HouseRobber.cs)  | DP          |
| [House Robber II](https://leetcode.com/problems/house-robber-ii/)                               | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| [Decode Ways](https://leetcode.com/problems/decode-ways/)                                       | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| [Unique Paths](https://leetcode.com/problems/unique-paths/)                                     | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| [Jump Game](https://leetcode.com/problems/jump-game/)                                           | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| [Word Break](https://leetcode.com/problems/word-break/)                                         | Medium     |                 🤷🏻‍♂️                 |                                                          |             |
| **BONUS**                                                                                       | **---**    |               **🙌🏻**               | **---**                                                  | **---**     |
| [The Maze](https://leetcode.com/problems/the-maze/)                                             | Medium     |                 🤷🏻‍♂️                 | [SlidingMaze.cs](./Blind75CSharp/Week05/SlidingMaze.cs)  | SquareUp    |
| [LRU Cache](https://leetcode.com/problems/lru-cache/)                                           | Medium     |                 🤷🏻‍♂️                 | [LRUCache](./Blind75CSharp/week05/LRUCache.cs)           | LinkList    |
| [Random Pick with Weight](https://leetcode.com/problems/random-pick-with-weight/)               | Medium     |                 🤷🏻‍♂️                 | [RandomPick.cs](./Blind75CSharp/Week05/RandomPick.cs)    | Google      |
| [Reorganize String](https://leetcode.com/problems/reorganize-string/)                           | Medium     | [🚀](https://youtu.be/2g_b1aYTHeg) | [ReorganizeString](./Blind75CSharp/Week05/Solution05.cs) | Space X     |
| [Baseball Game](https://leetcode.com/problems/baseball-game/)                                   | EZ         | [🚀](https://youtu.be/Id_tqGdsZQI) | [CalPoints](./Blind75CSharp/Week05/Solution05.cs)        | SpeedRun    |
| [Merge k Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/)                     | Hard       |                 🤷🏻‍♂️                 | [MergeKLists](./Blind75CSharp/Week05/Solution05.cs)      | Competition |
| [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/)                         | EZ         | [🚀](https://youtu.be/P1Ic85RarKY) | [Merge](./Blind75CSharp/Week05/Solution05.cs)            | x2 ptr      |
| [Sort List](https://leetcode.com/problems/sort-list/)                                           | Medium     | [🚀](https://youtu.be/TGveA1oFhrc) | [SortList](./Blind75CSharp/Week05/Solution05.cs)         | MergeSort   |
| [Buildings With an Ocean View](https://leetcode.com/problems/buildings-with-an-ocean-view/)     | Med        |                 🤷🏻‍♂️                 | [FindBuildings](./Blind75CSharp/Week05/Solution05.cs)    | FaceBook    |
| [Sum of Subarray Ranges](https://leetcode.com/problems/sum-of-subarray-ranges/)                 | EZ/Hard+   |                 🤷🏻‍♂️                 | [SubArrayRanges](./Blind75CSharp/Week05/Solution05.cs)   | MonoStack   |

---

### Week 6 - Just keep grinding problems

| Question                                                                                                | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                                   | Category     |
| ------------------------------------------------------------------------------------------------------- | ---------- | :-------------------------------: | -------------------------------------------------------------------------- | ------------ |
| [Word Break](https://leetcode.com/problems/word-break/)                                                 | Med        |                 🤷🏻‍♂️                 | [WordBreak](./Blind75CSharp/Week06/Solution06.cs)                          | Recursion/DP |
| [Swim in Rising Water](https://leetcode.com/problems/swim-in-rising-water/)                             | Hard       | [🚀](https://youtu.be/amvrKlMLuGY) |                                                                            | Dj           |
| [Min Cost to Connect All Points](https://leetcode.com/problems/min-cost-to-connect-all-points/)         | Med        | [🚀](https://youtu.be/f7JOBJIC-NA) |                                                                            | Prim         |
| [Analyze User Website Visit Pattern](https://leetcode.com/problems/analyze-user-website-visit-pattern/) | Med        |                 🤷🏻‍♂️                 | [MostVisitedPattern](./Blind75CSharp/Week06/Solution06.cs)                 | Amazon       |
| [Reorder Data in Log Files](https://leetcode.com/problems/reorder-data-in-log-files/)                   | Med        |                 🤷🏻‍♂️                 | [DataLog.cs](./Blind75CSharp/Week06/DataLog.cs)                            | Amazon       |
| [Maximum Units on a Truck](https://leetcode.com/problems/maximum-units-on-a-truck/)                     | Ez         |                 🤷🏻‍♂️                 | [MaximumUnits](./Blind75CSharp/Week06/Solution06.cs)                       | Amazon       |
| [Valid Word Abbreviation](https://leetcode.com/problems/valid-word-abbreviation/)                       | Ez         |                 🤷🏻‍♂️                 | [ValidWordAbbreviation](./Blind75CSharp/Week06/Solution06.cs)              | Meta         |
| [ValidPalindrome](https://leetcode.com/problems/valid-palindrome-ii/)                                   | Ez         |                 🤷🏻‍♂️                 | [ValidPalindrome](./Blind75CSharp/Week06/Solution06.cs)                    | Meta         |
| [MovingAverage](https://leetcode.com/problems/moving-average-from-data-stream/)                         | Ez         |                 🤷🏻‍♂️                 | [MovingAverage](./Blind75CSharp/Week06/MovingAverage.cs)                   | Meta         |
| [Zigzag Conversion](https://leetcode.com/problems/zigzag-conversion/)                                   | Med        |                 🤷🏻‍♂️                 | [ZigZag](./Blind75CSharp/Week06/ZigZag.cs)                                 | Popular      |
| [3Sum Closest](https://leetcode.com/problems/3sum-closest/)                                             | Med        |                 🤷🏻‍♂️                 | [ThreeSumClosest](./Blind75CSharp/Week06/Solution06.cs)                    | Popular      |
| [Roman to Integer](https://leetcode.com/problems/roman-to-integer/)                                     | Ez         |                 🤷🏻‍♂️                 | [RomanToInt](./Blind75CSharp/Week06/Solution06.cs)                         | Popular      |
| [NumUniqueEmails](https://leetcode.com/problems/unique-email-addresses/)                                | Ez         |                 🤷🏻‍♂️                 | [NumUniqueEmails](./Blind75CSharp/Week06/Solution06.cs)                    | Comp         |
| [Shortest Bridge](https://leetcode.com/problems/shortest-bridge/)                                       | Med        | [🚀](https://youtu.be/gkINMhbbIbU) | [ShortestBridge](./Blind75CSharp/week06/../GoogleTop100/ShortestBridge.cs) | Google       |
| [Making A Large Island](https://leetcode.com/problems/making-a-large-island/)                           | Hard       |                 🤷🏻‍♂️                 | [Island](./Blind75CSharp/Week06/../GoogleTop100/Island.cs)                 | Google       |
| [Maximum Points](https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/)               | Med        | [🚀](https://youtu.be/TsA4vbtfCvo) | [MaxScore](./Blind75CSharp/Week06/../GoogleTop100/Cards.cs)                | Google       |
| [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/)                               | Hard       |                 🤷🏻‍♂️                 | [Trap](./Blind75CSharp/Week06/Solution06.cs)                               | Popular      |
| [Design In-Memory File System](https://leetcode.com/problems/design-in-memory-file-system/)             | Hard       |                 🤷🏻‍♂️                 | [FileSystem](./Blind75CSharp/Week06/FileSystem.cs)                         | Popular      |
| [Surrounded Regions](https://leetcode.com/problems/surrounded-regions/)                                 | Med        | [🚀](https://youtu.be/9z2BunfoZ5Y) | [Surround](./Blind75CSharp/Week06/Surround.cs)                             | NC           |
| [Longest Happy String](https://leetcode.com/problems/longest-happy-string/submissions/)                 | Med        | [🚀](https://youtu.be/8u-H6O_XQKE) | [HappyString](./Blind75CSharp/Week06/HappyString.cs)                       | NC           |

---

## 🧡 Favorite Resources

### Understanding Solutions

- [NeetCode website](https://neetcode.io/)
- NeetCode [YouTube](https://www.youtube.com/c/NeetCode)

### Graphs

- [Dynamic Programming](https://youtu.be/oBt53YbR9Kk) | Alvin
- [Graph Algorithms for Technical Interviews](https://youtu.be/tWVWeAqZ0WU) | Alvin
- [Topological Sort | Kahn's Algorithm](https://youtu.be/cIBFEhD77b4) | William
- [Dijkstra's Shortest Path Algorithm](https://youtu.be/pSqmAO-m7Lk) | William
- [Union Find Introduction](https://youtu.be/ibjEGG7ylHk) | William
- More [DP Problems](https://docs.google.com/spreadsheets/d/1pEzcVLdj7T4fv5mrNhsOvffBnsUH07GZk7c2jD-adE0/edit?usp=sharing) | NeetCode

### Design

- [Scalability & System Design for Developers](https://www.educative.io/path/scalability-system-design) paid course
- [System Design Interview](https://www.youtube.com/c/SystemDesignInterview) on YouTube
- Medium author [Kousik Nath](https://kousiknath.medium.com/)

### Other

- [7 onsites, 7 offers](https://www.teamblind.com/post/7-onsites-7-offers-aAFTykAD) from Netflix alum
