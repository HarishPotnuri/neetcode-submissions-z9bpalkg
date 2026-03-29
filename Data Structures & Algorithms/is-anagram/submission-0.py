class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        ls = len(s)
        lt = len(t)

        if (ls != lt):
            return False

        myarr = [0] * 26;
    
        for i in range(ls):
            myarr[ord(s[i])-97]+=1
            myarr[ord(t[i])-97]-=1

        for i in range(26):
            if (myarr[i] != 0):
                return False
        return True

