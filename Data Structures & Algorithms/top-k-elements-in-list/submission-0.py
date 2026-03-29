class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        myDict = {}
        for i in nums:
            if i in myDict:
                myDict[i] += 1
            else:
                myDict[i] = 1
        
        sorted_items = sorted(myDict.items(), key=lambda kv: (kv[1]), reverse = True)
        return list(map(lambda x: x[0], sorted_items[:k]))
        