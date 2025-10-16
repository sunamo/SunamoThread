# NuGet Alternatives to SunamoThread

This document lists popular NuGet packages that provide similar functionality to SunamoThread.

## Overview

Threading utilities

## Alternative Packages

### System.Threading
- **NuGet**: System.Threading
- **Purpose**: Built-in threading
- **Key Features**: Thread, ThreadPool, synchronization primitives

### System.Threading.Tasks
- **NuGet**: System.Threading.Tasks
- **Purpose**: Task-based async
- **Key Features**: Task, async/await, parallel operations

### Nito.AsyncEx
- **NuGet**: Nito.AsyncEx
- **Purpose**: Async utilities
- **Key Features**: AsyncLock, AsyncManualResetEvent, AsyncContext

### System.Threading.Channels
- **NuGet**: System.Threading.Channels
- **Purpose**: Producer/consumer channels
- **Key Features**: Thread-safe data passing

## Comparison Notes

Modern async/await is preferred. Use Task instead of Thread. Nito.AsyncEx for advanced scenarios.

## Choosing an Alternative

Consider these alternatives based on your specific needs:
- **System.Threading**: Built-in threading
- **System.Threading.Tasks**: Task-based async
- **Nito.AsyncEx**: Async utilities
