class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        myDict = {}
        
        for i,v in enumerate(nums):
            targ = target - v
            if targ in myDict:
                return [myDict[targ], i]
            myDict[v] = i
            

        