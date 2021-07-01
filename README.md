# ObfusecateC
ObfusecateC
## 何のためのコード？
C言語のソースコードを読みにくくするためのソースコードです。  
.Net Coreで開発しました。

## できること
ソースコード中のトークンを、マクロですべて定義・置換します。
置換されたコード列は一行のソースコードとして吐き出されます。
ただし、プリプロセッサ命令はそのまま出力されます

### 実行例
[処理前のソースコード]
```c
  
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
```

[処理後のコード]
#include <stdio.h> 
#include <stdlib.h> 
#include <math.h> 
#include <stdbool.h> 

#define N_MAX 10000 
#define VICEAROUNDCOURTbTIME int
#define VICEOFVICEcCOURT cmp(const
#define TAKANEZAWATOTAKANEZAWAuCHICKEN void
#define TIMEINTOVIRTUEnBOMB *a,
#define ABELFROMENDOdCHICKEN const
#define SAXNEXT_TOTAKANEZAWAzSAX *b)
#define VIRTUEFROMHOUSEtONIKU {
#define VIRTUENEXT_TOCOURTmSAX return
#define ABELAMONGTIMEhTIME *(int
#define NEXT_STAGEOFODANOBUNAGAfPOPING *)a
#define BOMBFROMTIMEqNEXT_STAGE -
#define VIRTUEINTOABELxPOPING *)b;
#define BOMBINTONEXT_STAGEsTIME }
#define ABELAMONGTIMEhABEL main(void)
#define NEXT_STAGEFROMENDOhSAX n,
#define HOUSEAMONGHOUSEhSAX a[N_MAX],
#define POPINGOFVIRTUEzONIKU ans[N_MAX];
#define ODANOBUNAGAINVIRTUErONIKU bool
#define ENDOINTOTAKANEZAWAjROOK isOK
#define VIRTUEAROUNDVIRTUEzTIME =
#define CHICKENAROUNDPOPINGeNEXT_STAGE true;
#define SAXAMONGODANOBUNAGAwBOMB scanf("%d",
#define NEXT_STAGEONROOKgTIME &n);
#define COURTTOABELqTIME for
#define COURTTOCHICKENeSAX (int
#define ABELOFROOKoTIME i
#define POPINGTOTAKANEZAWAeVIRTUE 0;
#define COURTINPOPINGqTAKANEZAWA <
#define HOUSEOFNEXT_STAGEaSAX n;
#define SAXAMONGVICEfTIME i++)
#define ONIKUTOABELgVIRTUE &a[i]);
#define ABELNEXT_TOENDOjNEXT_STAGE qsort(a,
#define ABELONKUWAZAWAyTIME sizeof(int),
#define VICEFROMPOPINGuONIKU cmp);
#define NEXT_STAGEFROMSAXaPOPING if
#define ONIKUFROMABELeTIME (a[i]
#define POPINGFROMCHICKENxSAX !=
#define KUWAZAWATOONIKUoTIME +
#define HOUSEAMONGVICEsROOK 1)
#define ABELAROUNDTAKANEZAWAcTIME false;
#define SAXINVIRTUEfTIME break;
#define COURTAROUNDONIKUnTIME (isOK)
#define VICEAROUNDSAXuNEXT_STAGE printf("Yes\n");
#define TAKANEZAWANEXT_TOVIRTUEtABEL else
#define ROOKAMONGNEXT_STAGEoNEXT_STAGE printf("No\n");
VICEAROUNDCOURTbTIME VICEOFVICEcCOURT TAKANEZAWATOTAKANEZAWAuCHICKEN TIMEINTOVIRTUEnBOMB ABELFROMENDOdCHICKEN TAKANEZAWATOTAKANEZAWAuCHICKEN SAXNEXT_TOTAKANEZAWAzSAX VIRTUEFROMHOUSEtONIKU VIRTUENEXT_TOCOURTmSAX ABELAMONGTIMEhTIME NEXT_STAGEOFODANOBUNAGAfPOPING BOMBFROMTIMEqNEXT_STAGE ABELAMONGTIMEhTIME VIRTUEINTOABELxPOPING BOMBINTONEXT_STAGEsTIME VICEAROUNDCOURTbTIME ABELAMONGTIMEhABEL VIRTUEFROMHOUSEtONIKU VICEAROUNDCOURTbTIME NEXT_STAGEFROMENDOhSAX HOUSEAMONGHOUSEhSAX POPINGOFVIRTUEzONIKU ODANOBUNAGAINVIRTUErONIKU ENDOINTOTAKANEZAWAjROOK VIRTUEAROUNDVIRTUEzTIME CHICKENAROUNDPOPINGeNEXT_STAGE SAXAMONGODANOBUNAGAwBOMB NEXT_STAGEONROOKgTIME COURTTOABELqTIME COURTTOCHICKENeSAX ABELOFROOKoTIME VIRTUEAROUNDVIRTUEzTIME POPINGTOTAKANEZAWAeVIRTUE ABELOFROOKoTIME COURTINPOPINGqTAKANEZAWA HOUSEOFNEXT_STAGEaSAX SAXAMONGVICEfTIME VIRTUEFROMHOUSEtONIKU SAXAMONGODANOBUNAGAwBOMB ONIKUTOABELgVIRTUE BOMBINTONEXT_STAGEsTIME ABELNEXT_TOENDOjNEXT_STAGE NEXT_STAGEFROMENDOhSAX ABELONKUWAZAWAyTIME VICEFROMPOPINGuONIKU COURTTOABELqTIME COURTTOCHICKENeSAX ABELOFROOKoTIME VIRTUEAROUNDVIRTUEzTIME POPINGTOTAKANEZAWAeVIRTUE ABELOFROOKoTIME COURTINPOPINGqTAKANEZAWA HOUSEOFNEXT_STAGEaSAX SAXAMONGVICEfTIME VIRTUEFROMHOUSEtONIKU NEXT_STAGEFROMSAXaPOPING ONIKUFROMABELeTIME POPINGFROMCHICKENxSAX ABELOFROOKoTIME KUWAZAWATOONIKUoTIME HOUSEAMONGVICEsROOK VIRTUEFROMHOUSEtONIKU ENDOINTOTAKANEZAWAjROOK VIRTUEAROUNDVIRTUEzTIME ABELAROUNDTAKANEZAWAcTIME SAXINVIRTUEfTIME BOMBINTONEXT_STAGEsTIME BOMBINTONEXT_STAGEsTIME NEXT_STAGEFROMSAXaPOPING COURTAROUNDONIKUnTIME VIRTUEFROMHOUSEtONIKU VICEAROUNDSAXuNEXT_STAGE BOMBINTONEXT_STAGEsTIME TAKANEZAWANEXT_TOVIRTUEtABEL VIRTUEFROMHOUSEtONIKU ROOKAMONGNEXT_STAGEoNEXT_STAGE BOMBINTONEXT_STAGEsTIME BOMBINTONEXT_STAGEsTIME 
