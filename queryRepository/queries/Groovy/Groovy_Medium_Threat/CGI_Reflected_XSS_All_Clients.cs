CxList inputs = Find_Interactive_Inputs();
CxList outputs = Find_Console_Outputs();

CxList sanitized = Find_XSS_Sanitize() + Find_DB_In();

result = inputs.InfluencingOnAndNotSanitized(outputs, sanitized);