# todo
A simple Todo list application to show dynamic runtime binding.

## Overview

As part of our discussions about how to test HTTP Web APIs, we hit a problem; it is not possible to test the service in isolation if it is running within an HTTP context.

We need to test services in isolation within the HTTP context because i) the controller may contain some validation or other logic, ii) we need to test the entire HTTP request/response round-trip in order to check response statuses and other protocol-related properties. But at the same time, we don't want to hit actual dependencies (databases, doc stores, other services etc) because then our tests will not be isolated and may fail for conditions outside their control.

This project proposes a way to test a single service including the HTTP context handling shell BUT with stubbed third party dependencies.
