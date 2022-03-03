#include "pch.h"
#include "Test.h"

JNIEXPORT jint JNICALL Java_Test_Sum
(JNIEnv*, jobject, jint a, jint b)
{
	return a + b;
}