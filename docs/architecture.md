# Architecture

## Overview

AI Playground follows a simplified Clean Architecture approach to keep business logic independent from external AI providers.

The first provider implemented will be OpenRouter, but the application layer should remain provider-agnostic.

## Layers

### API

Responsible for HTTP endpoints, request/response handling, Swagger, middleware, and dependency injection setup.

### Application

Contains use cases, service contracts, DTOs, and application services.

This layer should not know about OpenRouter or any specific AI provider.

### Domain

Contains core entities and business rules.

### Infrastructure

Contains external integrations such as OpenRouter, databases, repositories, and HTTP clients.

## Current Flow

```text
Controller
     |
     v
IChatService
     |
     v
IAIProviderClient
     |
     v
OpenRouterClient
     |
     v
OpenRouter API