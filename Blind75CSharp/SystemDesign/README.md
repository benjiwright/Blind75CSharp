# System Design Interview

## Requirements

### Functional

1. break into services that will be required

### Non-functional

1. security: at rest and in transit
2. are we storing sensitive data? GDPR (EU)

### Clarify

1. is this for browser, mobile, VR? (do not constrain yourself)

#### Capacities Estimates (maybe skip)

system is distributed and will be (1) scalable (2) available

1. Traffic (QPS)
2. Storage
   1. Read vs. Write heavy
   2. lifecycle
   3. consistency model
      1. strong (strict)
         1. read might not be available
         2. higher latency
         3. not supported globally
      2. eventual
3. Bandwidth (kb/s)
   1. CDN or S3 w/ CloudFront, etc
4. Memory

API GW

* throttling
* auth (token verification)
* routing
* whitelist IP/region/etc
