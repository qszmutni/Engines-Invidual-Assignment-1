#pragma once

#include "PluginSettings.h"
#include "SimpleClass.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Call functions here
	PLUGIN_API int SimpleFunction();
	PLUGIN_API void wrapperWrite(float x, float y, float z);
	PLUGIN_API void wrapperRead();
	PLUGIN_API void wrapperDelete();

	PLUGIN_API void wrapperSet(std::string unityPos);
	PLUGIN_API std::string wrapperGet();
	PLUGIN_API float wrapperX();
	PLUGIN_API float wrapperY();
	PLUGIN_API float wrapperZ();

#ifdef __cplusplus 
}
#endif
