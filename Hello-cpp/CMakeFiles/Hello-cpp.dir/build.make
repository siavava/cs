# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.22

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /mnt/c/Users/amitt/source/repos/cs/Hello-cpp

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /mnt/c/Users/amitt/source/repos/cs/Hello-cpp

# Include any dependencies generated for this target.
include CMakeFiles/Hello-cpp.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CMakeFiles/Hello-cpp.dir/compiler_depend.make

# Include the progress variables for this target.
include CMakeFiles/Hello-cpp.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/Hello-cpp.dir/flags.make

CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o: CMakeFiles/Hello-cpp.dir/flags.make
CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o: Hello-cpp.cpp
CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o: CMakeFiles/Hello-cpp.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/mnt/c/Users/amitt/source/repos/cs/Hello-cpp/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o -MF CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o.d -o CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o -c /mnt/c/Users/amitt/source/repos/cs/Hello-cpp/Hello-cpp.cpp

CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /mnt/c/Users/amitt/source/repos/cs/Hello-cpp/Hello-cpp.cpp > CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.i

CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /mnt/c/Users/amitt/source/repos/cs/Hello-cpp/Hello-cpp.cpp -o CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.s

# Object files for target Hello-cpp
Hello__cpp_OBJECTS = \
"CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o"

# External object files for target Hello-cpp
Hello__cpp_EXTERNAL_OBJECTS =

Hello-cpp: CMakeFiles/Hello-cpp.dir/Hello-cpp.cpp.o
Hello-cpp: CMakeFiles/Hello-cpp.dir/build.make
Hello-cpp: CMakeFiles/Hello-cpp.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/mnt/c/Users/amitt/source/repos/cs/Hello-cpp/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable Hello-cpp"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/Hello-cpp.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/Hello-cpp.dir/build: Hello-cpp
.PHONY : CMakeFiles/Hello-cpp.dir/build

CMakeFiles/Hello-cpp.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/Hello-cpp.dir/cmake_clean.cmake
.PHONY : CMakeFiles/Hello-cpp.dir/clean

CMakeFiles/Hello-cpp.dir/depend:
	cd /mnt/c/Users/amitt/source/repos/cs/Hello-cpp && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /mnt/c/Users/amitt/source/repos/cs/Hello-cpp /mnt/c/Users/amitt/source/repos/cs/Hello-cpp /mnt/c/Users/amitt/source/repos/cs/Hello-cpp /mnt/c/Users/amitt/source/repos/cs/Hello-cpp /mnt/c/Users/amitt/source/repos/cs/Hello-cpp/CMakeFiles/Hello-cpp.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/Hello-cpp.dir/depend

