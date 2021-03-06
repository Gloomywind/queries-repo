/*
MISRA CPP RULE 9-5-1
------------------------------
This query searches for usage of unions

	The Example below shows code with vulnerability: 

union utag {
	float f1;      
	float fbit ; 
	unsigned long i1 : 1;
} u ;

*/

result = All.FindByRegex(@"\Wunion\W", false, false, false, All.NewCxList());