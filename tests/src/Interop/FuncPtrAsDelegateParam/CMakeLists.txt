cmake_minimum_required (VERSION 2.6)
project (FuncPtrAsDelegateParamNative)
include_directories(${INC_PLATFORM_DIR})
set(SOURCES FuncPtrAsDelegateParamNative.cpp )

# add the executable
add_library (FuncPtrAsDelegateParamNative SHARED ${SOURCES})

#get_cmake_property(_variableNames VARIABLES)
#foreach (_variableName ${_variableNames})
#    message(STATUS "${_variableName}=${${_variableName}}")
#endforeach()
 

#SET(LIBRARY_OUTPUT_PATH ${PROJECT_BINARY_DIR}/lib)

# add the install targets
install (TARGETS FuncPtrAsDelegateParamNative DESTINATION bin)