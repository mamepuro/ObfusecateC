#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <stdbool.h>

#define N_MAX 10000
int cmp(const void *a, const void *b)
{
    return *(int *)a - *(int *)b;
}
int main(void)
{
    int n, a[N_MAX], ans[N_MAX];
    bool isOK = true;
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", &a[i]);
    }
    qsort(a, n, sizeof(int), cmp);
    for (int i = 0; i < n; i++)
    {
        if (a[i] != i + 1)
        {
            isOK = false;
            break;
        }
    }
    if (isOK)
    {
        printf("Yes\n");
    }
    else
    {
        printf("No\n");
    }
}