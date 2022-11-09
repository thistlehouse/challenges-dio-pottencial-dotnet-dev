// int n = int.Parse(Console.ReadLine());
        
// int[] num = new int[n];


int[] num = { 5, 5, 3, 3, 3, 5, 3 };
// int[] num = { 2, 1, 1, 1, 2, 2, 2, 1, 2};
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = int.Parse(Console.ReadLine());
// }

Console.WriteLine(MajorityElement(num));

static int MajorityElement(int[] nums)
{
    int major = nums[0];
    int count = 1;
    
    for (int i = 0; i < nums.Length; i++)
    {
        if (count > i)
        {
            major = nums[i];
            count++;
        }
        else
        {
            if (major == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
    }

    return major;
}