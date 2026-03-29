class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        myDict = {}

        for s in strs:
            chArr = [0] * 26
            for c in s:
                chArr[ord(c) - 97] += 1
            h = str(chArr)
            if h in myDict:
                myDict[h].append(s)
            else:
                myDict[h] = [s]

        return myDict.values()
            
            