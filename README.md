# Blind Top 75 Leetcode Problems - in CSharp

Originally posted [here](https://www.teamblind.com/post/New-Year-Gift---Curated-List-of-Top-75-LeetCode-Questions-to-Save-Your-Time-OaM1orEU) entitled "*New Year Gift - Curated List of Top 75 LeetCode Questions to Save Your Time*"

The 75 most important algorithms to understand when preparing for a FAANGMULA type interview according to those that know more than I do.

## Approach

5 weeks of [LeetCode](https://leetcode.com/) questions broken into categories: sequences, data structures, non-linear data structures, more data structures, and finally dynamic programming.

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
| **BONUS**                                                                                         | **---**    |              **---**              | **---**                                                                 | **---**          | **---** |
| [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)               | Medium     | [🚀](https://youtu.be/lXVy6YWFcRM) | [MaxSubArrayFinder](#TODO)                                              | TODO?            |         |
| [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/)   | Medium     | [🚀](https://youtu.be/U8XENwh8Oy8) | [SearchRotatedArray](./Blind75CSharp/Week01/SearchRotatedArray.cs)      | Binary Search    |    Y    |
| [Two Sum II - Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/)            | Medium     | [🚀](https://youtu.be/cQ1Oz4ckceM) | [TwoSummer](./Blind75CSharp/Week01/TwoSummer.cs)                        | Double Pointers  |         |
| [Insert Interval](https://leetcode.com/problems/insert-interval/)                                 | Medium     | [🚀](https://youtu.be/A8NUOmlwOlM) | [Intervals](./Blind75CSharp/Week01/Intervals.cs)                        | Intervals        |    Y    |

### Week 2 - Data structures

The focus of week 2 is on linked lists, strings and matrix-based questions. The goal is to learn the common routines dealing with linked lists, traversing matrices and sequence analysis (arrays/strings) techniques such as sliding window, linked list traversal and matrix traversal.

| Question                                                                                                                        | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                                            | Category        |  Redo   |
| ------------------------------------------------------------------------------------------------------------------------------- | ---------- | --------------------------------- | ------------------------------------------------------------------- | --------------- | :-----: |
| [Reverse a Linked List](https://leetcode.com/problems/reverse-linked-list/)                                                     | Easy       | [🚀](#)                            | [ReverseList](./Blind75CSharp/Week02/Solution.cs)                   | Linked Lists    |         |
| [Detect Cycle in a Linked List](https://leetcode.com/problems/linked-list-cycle/)                                               | Easy       | [🚀](#)                            | [HasCycle](./Blind75CSharp/Week02/Solution.cs)                      | Linked Lists    |         |
| [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/)                     | Medium     | [🚀](#)                            | [SearchRotatedArray](./Blind75CSharp/Week01/SearchRotatedArray.cs)  | Double Pointers |         |
| [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)                                           | Medium     | [🚀](https://youtu.be/UuiTKBwPgAo) | [MaxArea](./Blind75CSharp/Week02/Solution.cs)                       | Double Pointers |         |
| [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)               | Medium     | [🚀](https://youtu.be/gqXU1UyA8pk) | [CharacterReplacement](./Blind75CSharp/Week02/LetterReplacement.cs) | Double Pointers |         |
| [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | Medium     | [🚀](#)                            | [LengthOfLongestSubstring](./Blind75CSharp/Week02/Solution.cs)      | Double Pointers |         |
| [Number of Islands](https://leetcode.com/problems/number-of-islands/)                                                           | Medium     | [🚀](#)                            | [NumIslands](./Blind75CSharp/Week02/Solution.cs)                    | Graph           |         |
| [Remove Nth Node From End Of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/)                             | Medium     | [🚀](https://youtu.be/XVuQxVej6y8) | [RemoveNthFromEnd](./Blind75CSharp/Week02/Solution.cs)              | Linked Lists    |         |
| [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/)                                                 | Medium     | [🚀](https://youtu.be/4RACzI5-du8) | [CountSubstrings](./Blind75CSharp/Week02/Solution.cs)               | Double Pointers |         |
| [Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/)                                       | Medium     | [🚀](https://youtu.be/s-VkcjHqkGI) | [PacificAtlantic](./Blind75CSharp/Week02/Solution.cs)               | Graph           |         |
| [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)                                             | Hard       | [🚀](https://youtu.be/jSto0O4AJbM) | [MinWindow](./Blind75CSharp/Week02/Solution.cs)                     | Sliding Window  |         |
| **BONUS**                                                                                                                       | **---**    | **---**                           | **---**                                                             | **---**         | **---** |
| [Find Median from Data Stream](https://leetcode.com/problems/find-median-from-data-stream/)                                     | Hard       | [🚀](https://youtu.be/itmhHWaHupI) | [MedianFinder.cs](./Blind75CSharp/Week02/MedianFinder.cs)           | Data Structures |         |
| [Implement Trie (Prefix Tree)](https://leetcode.com/problems/implement-trie-prefix-tree/)                                       | Medium     | [🚀](https://youtu.be/oobqoCJlHA0) | [Trie.cs](./Blind75CSharp/Week02/Trie.cs)                           | Data Structures |         |

### Week 3 - Non-linear data structures

The focus of week 3 is on non-linear data structures like trees, graphs and heaps. You should be familiar with the various tree traversal (in-order, pre-order, post-order) algorithms and graph traversal algorithms such as breadth-first search and depth-first search. In my experience, using more advanced graph algorithms (Dijkstra's and Floyd-Warshall) is quite rare and usually not necessary.

| Question                                                                                  | Difficulty | [NeetCode](https://neetcode.io/)  | Solution                                        | Category |  Redo   |
| ----------------------------------------------------------------------------------------- | ---------- | --------------------------------- | ----------------------------------------------- | -------- | :-----: |
| [Invert/Flip Binary Tree](https://leetcode.com/problems/invert-binary-tree/)              | Easy       | Link                              |                                                 |          |         |
| [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | Medium     | Link                              |                                                 |          |         |
| Non-overlapping Intervals                                                                 | Medium     | Link                              |                                                 |          |         |
| Construct Binary Tree from Preorder and Inorder Traversal                                 | Medium     | Link                              |                                                 |          |         |
| Top K Frequent Elements                                                                   | Medium     | Link                              |                                                 |          |         |
| Clone Graph                                                                               | Medium     | Link                              |                                                 |          |         |
| Course Schedule                                                                           | Medium     | Link                              |                                                 |          |         |
| Serialize and Deserialize Binary Tree                                                     | Hard       | Link                              |                                                 |          |         |
| Binary Tree Maximum Path Sum                                                              | Hard       | Link                              |                                                 |          |         |
| **BONUS**                                                                                 | **---**    | **---**                           | **---**                                         | **---**  | **---** |
| [Graph Valid Tree](https://leetcode.com/problems/graph-valid-tree/)                       | Medium     | [🚀](https://youtu.be/bXsUuownnoQ) | [ValidTree](./Blind75CSharp/Week03/Solution.cs) | Graph    |         |





### Bonus Week & Weekend

After the week's problems are done, let's focus in the Top 100 most frequently asked questions at [Google](https://leetcode.com/problem-list/top-google-questions/?sorting=W3sic29ydE9yZGVyIjoiREVTQ0VORElORyIsIm9yZGVyQnkiOiJGUkVRVUVOQ1kifV0%3D).

| Question                                                                               | Solution | Difficulty | Frequency |
| -------------------------------------------------------------------------------------- | -------- | ---------- | --------- |
| 528. [Random Pick with Weight](https://leetcode.com/problems/random-pick-with-weight/) |          | Medium     | 94%       |

## Entire Blind Top 75

Organized by problem category. Problems marked with `*` require LeetCode Premium.

### Array

- ✅[Two Sum](https://leetcode.com/problems/two-sum/)
- ✅[Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/)
- ✅[Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)
- ✅[Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/)
- ✅[Maximum Subarray](https://leetcode.com/problems/maximum-subarray/)
- ✅[Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/)
- ✅[Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/)
- ✅[Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/)
- ✅[3Sum](https://leetcode.com/problems/3sum/)
- ✅[Container With Most Water](https://leetcode.com/problems/container-with-most-water/)

---

### Binary

- Sum of Two Integers - https://leetcode.com/problems/sum-of-two-integers/
- Number of 1 Bits - https://leetcode.com/problems/number-of-1-bits/
- Counting Bits - https://leetcode.com/problems/counting-bits/
- Missing Number - https://leetcode.com/problems/missing-number/
- Reverse Bits - https://leetcode.com/problems/reverse-bits/

---

### Dynamic Programming

- Climbing Stairs - https://leetcode.com/problems/climbing-stairs/
- Coin Change - https://leetcode.com/problems/coin-change/
- Longest Increasing Subsequence - https://leetcode.com/problems/longest-increasing-subsequence/
- Longest Common Subsequence -
- Word Break Problem - https://leetcode.com/problems/word-break/
- Combination Sum - https://leetcode.com/problems/combination-sum-iv/
- House Robber - https://leetcode.com/problems/house-robber/
- House Robber II - https://leetcode.com/problems/house-robber-ii/
- Decode Ways - https://leetcode.com/problems/decode-ways/
- Unique Paths - https://leetcode.com/problems/unique-paths/
- Jump Game - https://leetcode.com/problems/jump-game/

---

### Graph

- Clone Graph - https://leetcode.com/problems/clone-graph/
- Course Schedule - https://leetcode.com/problems/course-schedule/
- ✅[Pacific Atlantic Water Flow](https://leetcode.com/problems/pacific-atlantic-water-flow/)
- ✅[Number of Islands](https://leetcode.com/problems/number-of-islands/)
- ✅[Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/)
- Alien Dictionary `*` - https://leetcode.com/problems/alien-dictionary/
- Graph Valid Tree - https://leetcode.com/problems/graph-valid-tree/
- Number of Connected Components in an Undirected Graph* - https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/

---

### Interval

- ✅[Insert Interval](https://leetcode.com/problems/insert-interval/)
- ✅[Merge Intervals](https://leetcode.com/problems/merge-intervals/)
- Non-overlapping Intervals - https://leetcode.com/problems/non-overlapping-intervals/
- Meeting Rooms `*` - https://leetcode.com/problems/meeting-rooms/
- Meeting Rooms `*` (Leetcode Premium) - https://leetcode.com/problems/meeting-rooms-ii/

---

### Linked List

- ✅[Reverse a Linked List](https://leetcode.com/problems/reverse-linked-list/)
- ✅[Detect Cycle in a Linked List](https://leetcode.com/problems/linked-list-cycle/)
- Merge Two Sorted Lists - https://leetcode.com/problems/merge-two-sorted-lists/
- Merge K Sorted Lists - https://leetcode.com/problems/merge-k-sorted-lists/
- ✅[Remove Nth Node From End Of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/)
- Reorder List - https://leetcode.com/problems/reorder-list/

---

### Matrix

- Set Matrix Zeroes - https://leetcode.com/problems/set-matrix-zeroes/
- Spiral Matrix - https://leetcode.com/problems/spiral-matrix/
- Rotate Image - https://leetcode.com/problems/rotate-image/
- Word Search - https://leetcode.com/problems/word-search/

---

### String

- ✅[Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/)
- ✅[Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/)
- ✅[Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/)
- ✅[Valid Anagram](https://leetcode.com/problems/valid-anagram/)
- ✅[Group Anagrams](https://leetcode.com/problems/group-anagrams/)
- ✅[Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)
- Valid Palindrome - https://leetcode.com/problems/valid-palindrome/
- Longest Palindromic Substring - https://leetcode.com/problems/longest-palindromic-substring/
- ✅[Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/)
- Encode and Decode Strings (Leetcode Premium) - https://leetcode.com/problems/encode-and-decode-strings/

---

### Tree

- Maximum Depth of Binary Tree - https://leetcode.com/problems/maximum-depth-of-binary-tree/
- Same Tree - https://leetcode.com/problems/same-tree/
- [Invert/Flip Binary Tree](https://leetcode.com/problems/invert-binary-tree/)
- Binary Tree Maximum Path Sum - https://leetcode.com/problems/binary-tree-maximum-path-sum/
- Binary Tree Level Order Traversal - https://leetcode.com/problems/binary-tree-level-order-traversal/
- Serialize and Deserialize Binary Tree - https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
- Subtree of Another Tree - https://leetcode.com/problems/subtree-of-another-tree/
- Construct Binary Tree from Preorder and Inorder Traversal - https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
- [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/)
- Kth Smallest Element in a BST - https://leetcode.com/problems/kth-smallest-element-in-a-bst/
- Lowest Common Ancestor of BST - https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
- Implement Trie (Prefix Tree) - https://leetcode.com/problems/implement-trie-prefix-tree/
- Add and Search Word - https://leetcode.com/problems/add-and-search-word-data-structure-design/
- Word Search II - https://leetcode.com/problems/word-search-ii/

---

### Heap

- Merge K Sorted Lists - https://leetcode.com/problems/merge-k-sorted-lists/
- Top K Frequent Elements - https://leetcode.com/problems/top-k-frequent-elements/
- Find Median from Data Stream - https://leetcode.com/problems/find-median-from-data-stream/

---

## Favorite Resources

### Graphs

- [Dynamic Programming](https://youtu.be/oBt53YbR9Kk) | Alvin
- [Graph Algorithms for Technical Interviews](https://youtu.be/tWVWeAqZ0WU) | Alvin
- [Topological Sort | Kahn's Algorithm](https://youtu.be/cIBFEhD77b4) | William
- [Dijkstra's Shortest Path Algorithm](https://youtu.be/pSqmAO-m7Lk) | William
- [Union Find Introduction](https://youtu.be/ibjEGG7ylHk) | William

### Design

- [Scalability & System Design for Developers](https://www.educative.io/path/scalability-system-design) paid course
- [System Design Interview](https://www.youtube.com/c/SystemDesignInterview) on YouTube
- Medium author [Kousik Nath](https://kousiknath.medium.com/)

### Other

- [7 onsites, 7 offers](https://www.teamblind.com/post/7-onsites-7-offers-aAFTykAD) from Netflix alum
