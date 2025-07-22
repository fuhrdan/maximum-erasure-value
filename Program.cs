//*****************************************************************************
//** 1695. Maximum Erasure Value                                    leetcode **
//*****************************************************************************

int maximumUniqueSubarray(int* nums, int numsSize) {
    int fried[100001] = {0};
    int left = 0;
    int right = 0;
    int hashbrown = 0;
    int order = 0;

    while(right < numsSize)
    {
        int val = nums[right];
        while(fried[val])
        {
            fried[nums[left]] = 0;
            hashbrown -= nums[left];
            left++;
        }

        fried[val] = 1;
        hashbrown += val;
        if(order < hashbrown)
        {
            order = hashbrown;
        }
        right++;
    }

    return order;
}