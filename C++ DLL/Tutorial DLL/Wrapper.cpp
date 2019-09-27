#include "Wrapper.h"

SimpleClass simpleClass;

int SimpleFunction() {

	return simpleClass.SimpleFunction();
}

void wrapperWrite(float x, float y, float z) {
	simpleClass.writeFunction(x, y, z);
}
void wrapperRead() {
	simpleClass.readFunction();
}
void wrapperDelete() {
	simpleClass.deleteFunction();
}

void wrapperSet(std::string unityPos) {
	simpleClass.setPos(unityPos);
}

std::string wrapperGet() {
	return simpleClass.getPos();
}

float wrapperX() {
	return simpleClass.getX();
}

float wrapperY() {
	return simpleClass.getY();
}
 
float wrapperZ() {
	return simpleClass.getZ();
}